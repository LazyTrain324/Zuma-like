//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MoveAnimationComponent moveAnimation { get { return (MoveAnimationComponent)GetComponent(GameComponentsLookup.MoveAnimation); } }
    public bool hasMoveAnimation { get { return HasComponent(GameComponentsLookup.MoveAnimation); } }

    public void AddMoveAnimation(float newDuration, UnityEngine.Vector3 newTarget, System.Action newPostAction) {
        var index = GameComponentsLookup.MoveAnimation;
        var component = (MoveAnimationComponent)CreateComponent(index, typeof(MoveAnimationComponent));
        component.duration = newDuration;
        component.target = newTarget;
        component.postAction = newPostAction;
        AddComponent(index, component);
    }

    public void ReplaceMoveAnimation(float newDuration, UnityEngine.Vector3 newTarget, System.Action newPostAction) {
        var index = GameComponentsLookup.MoveAnimation;
        var component = (MoveAnimationComponent)CreateComponent(index, typeof(MoveAnimationComponent));
        component.duration = newDuration;
        component.target = newTarget;
        component.postAction = newPostAction;
        ReplaceComponent(index, component);
    }

    public void RemoveMoveAnimation() {
        RemoveComponent(GameComponentsLookup.MoveAnimation);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMoveAnimation;

    public static Entitas.IMatcher<GameEntity> MoveAnimation {
        get {
            if (_matcherMoveAnimation == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoveAnimation);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMoveAnimation = matcher;
            }

            return _matcherMoveAnimation;
        }
    }
}