//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ManageContext {

    public ManageEntity totalScoreEntity { get { return GetGroup(ManageMatcher.TotalScore).GetSingleEntity(); } }
    public TotalScoreComponent totalScore { get { return totalScoreEntity.totalScore; } }
    public bool hasTotalScore { get { return totalScoreEntity != null; } }

    public ManageEntity SetTotalScore(int newValue) {
        if (hasTotalScore) {
            throw new Entitas.EntitasException("Could not set TotalScore!\n" + this + " already has an entity with TotalScoreComponent!",
                "You should check if the context already has a totalScoreEntity before setting it or use context.ReplaceTotalScore().");
        }
        var entity = CreateEntity();
        entity.AddTotalScore(newValue);
        return entity;
    }

    public void ReplaceTotalScore(int newValue) {
        var entity = totalScoreEntity;
        if (entity == null) {
            entity = SetTotalScore(newValue);
        } else {
            entity.ReplaceTotalScore(newValue);
        }
    }

    public void RemoveTotalScore() {
        totalScoreEntity.Destroy();
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
public partial class ManageEntity {

    public TotalScoreComponent totalScore { get { return (TotalScoreComponent)GetComponent(ManageComponentsLookup.TotalScore); } }
    public bool hasTotalScore { get { return HasComponent(ManageComponentsLookup.TotalScore); } }

    public void AddTotalScore(int newValue) {
        var index = ManageComponentsLookup.TotalScore;
        var component = (TotalScoreComponent)CreateComponent(index, typeof(TotalScoreComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTotalScore(int newValue) {
        var index = ManageComponentsLookup.TotalScore;
        var component = (TotalScoreComponent)CreateComponent(index, typeof(TotalScoreComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTotalScore() {
        RemoveComponent(ManageComponentsLookup.TotalScore);
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
public sealed partial class ManageMatcher {

    static Entitas.IMatcher<ManageEntity> _matcherTotalScore;

    public static Entitas.IMatcher<ManageEntity> TotalScore {
        get {
            if (_matcherTotalScore == null) {
                var matcher = (Entitas.Matcher<ManageEntity>)Entitas.Matcher<ManageEntity>.AllOf(ManageComponentsLookup.TotalScore);
                matcher.componentNames = ManageComponentsLookup.componentNames;
                _matcherTotalScore = matcher;
            }

            return _matcherTotalScore;
        }
    }
}
