//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GlobalContext {

    public GlobalEntity levelConfigEntity { get { return GetGroup(GlobalMatcher.LevelConfig).GetSingleEntity(); } }
    public LevelConfigComponent levelConfig { get { return levelConfigEntity.levelConfig; } }
    public bool hasLevelConfig { get { return levelConfigEntity != null; } }

    public GlobalEntity SetLevelConfig(LevelConfig newValue) {
        if (hasLevelConfig) {
            throw new Entitas.EntitasException("Could not set LevelConfig!\n" + this + " already has an entity with LevelConfigComponent!",
                "You should check if the context already has a levelConfigEntity before setting it or use context.ReplaceLevelConfig().");
        }
        var entity = CreateEntity();
        entity.AddLevelConfig(newValue);
        return entity;
    }

    public void ReplaceLevelConfig(LevelConfig newValue) {
        var entity = levelConfigEntity;
        if (entity == null) {
            entity = SetLevelConfig(newValue);
        } else {
            entity.ReplaceLevelConfig(newValue);
        }
    }

    public void RemoveLevelConfig() {
        levelConfigEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GlobalEntity {

    public LevelConfigComponent levelConfig { get { return (LevelConfigComponent)GetComponent(GlobalComponentsLookup.LevelConfig); } }
    public bool hasLevelConfig { get { return HasComponent(GlobalComponentsLookup.LevelConfig); } }

    public void AddLevelConfig(LevelConfig newValue) {
        var index = GlobalComponentsLookup.LevelConfig;
        var component = (LevelConfigComponent)CreateComponent(index, typeof(LevelConfigComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceLevelConfig(LevelConfig newValue) {
        var index = GlobalComponentsLookup.LevelConfig;
        var component = (LevelConfigComponent)CreateComponent(index, typeof(LevelConfigComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveLevelConfig() {
        RemoveComponent(GlobalComponentsLookup.LevelConfig);
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
public sealed partial class GlobalMatcher {

    static Entitas.IMatcher<GlobalEntity> _matcherLevelConfig;

    public static Entitas.IMatcher<GlobalEntity> LevelConfig {
        get {
            if (_matcherLevelConfig == null) {
                var matcher = (Entitas.Matcher<GlobalEntity>)Entitas.Matcher<GlobalEntity>.AllOf(GlobalComponentsLookup.LevelConfig);
                matcher.componentNames = GlobalComponentsLookup.componentNames;
                _matcherLevelConfig = matcher;
            }

            return _matcherLevelConfig;
        }
    }
}