﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Entitas;
using PathCreation;
using System.Linq;

/// <summary>
/// Логика изменения позиции шаров на треке, в зависимости от их дистанции
/// </summary>
public class ChangeBallPositionOnPathSystem : ReactiveSystem<GameEntity>, ITearDownSystem
{
    private Contexts _contexts;
    private Dictionary<int, GameEntity> chains;
    private Dictionary<int, GameEntity> tracks;

    public ChangeBallPositionOnPathSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
        chains = new Dictionary<int, GameEntity>();
        tracks = new Dictionary<int, GameEntity>();
    }

    protected override void Execute(List<GameEntity> entities)
    {
        for(int i = 0; i < entities.Count; i++)
        {
            if (entities[i].hasAnimationInfo || entities[i].hasMoveAnimation || entities[i].hasScaleAnimation)
                continue;

            var chain = GetChain(entities[i].parentChainId.value);
            if(chain == null)
            {
                _contexts.manage.CreateEntity()
                    .AddLogMessage($"Failed to change disntace ball. Chain is null", TypeLogMessage.Error, true, GetType());
                continue;
            }

            var track = GetTrack(chain.parentTrackId.value);
            if (track == null)
            {
                _contexts.manage.CreateEntity()
                    .AddLogMessage($"Failed to change disntace ball. Track is null", TypeLogMessage.Error, true, GetType());
                continue;
            }

            float distance = entities[i].distanceBall.value;
            PathCreator pathCreator = track.pathCreator.value;

            // Move Position
            Vector2 position = pathCreator.path.GetPointAtDistance(distance, EndOfPathInstruction.Stop);
            // TODO: change to MovePosition()
            entities[i].transform.value.position = position;

            // Rotate
            // increase CPU perfomance by 150 %     
            // TODO: try to optimize
            Vector3 direction = pathCreator.path.GetDirectionAtDistance(distance, EndOfPathInstruction.Stop);
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, direction);
            entities[i].transform.value.rotation = rotation;
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasDistanceBall && entity.hasTransform;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.DistanceBall);
    }

    public void TearDown()
    {
        chains.Clear();
        tracks.Clear();
    }

    #region Private Methods
    private GameEntity GetChain(int chainId)
    {
        if (!chains.ContainsKey(chainId))
        {
            var newChain = _contexts.game.GetEntitiesWithChainId(chainId).FirstOrDefault();
            if (newChain == null)
                return null;
            chains.Add(chainId, newChain);
        }

        return chains[chainId];
    }

    private GameEntity GetTrack(int trackId)
    {
        if (!tracks.ContainsKey(trackId))
        {
            var newTrack = _contexts.game.GetEntitiesWithTrackId(trackId).FirstOrDefault();
            if (newTrack == null)
                return null;
            tracks.Add(trackId, newTrack);
        }

        return tracks[trackId];
    }
    #endregion
}
