//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ManageContext {

    public ManageEntity startPlayEventEntity { get { return GetGroup(ManageMatcher.StartPlayEvent).GetSingleEntity(); } }
    public StartPlayEventComponent startPlayEvent { get { return startPlayEventEntity.startPlayEvent; } }
    public bool hasStartPlayEvent { get { return startPlayEventEntity != null; } }

    public ManageEntity SetStartPlayEvent(System.Collections.Generic.List<System.Action> newValue) {
        if (hasStartPlayEvent) {
            throw new Entitas.EntitasException("Could not set StartPlayEvent!\n" + this + " already has an entity with StartPlayEventComponent!",
                "You should check if the context already has a startPlayEventEntity before setting it or use context.ReplaceStartPlayEvent().");
        }
        var entity = CreateEntity();
        entity.AddStartPlayEvent(newValue);
        return entity;
    }

    public void ReplaceStartPlayEvent(System.Collections.Generic.List<System.Action> newValue) {
        var entity = startPlayEventEntity;
        if (entity == null) {
            entity = SetStartPlayEvent(newValue);
        } else {
            entity.ReplaceStartPlayEvent(newValue);
        }
    }

    public void RemoveStartPlayEvent() {
        startPlayEventEntity.Destroy();
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

    public StartPlayEventComponent startPlayEvent { get { return (StartPlayEventComponent)GetComponent(ManageComponentsLookup.StartPlayEvent); } }
    public bool hasStartPlayEvent { get { return HasComponent(ManageComponentsLookup.StartPlayEvent); } }

    public void AddStartPlayEvent(System.Collections.Generic.List<System.Action> newValue) {
        var index = ManageComponentsLookup.StartPlayEvent;
        var component = (StartPlayEventComponent)CreateComponent(index, typeof(StartPlayEventComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStartPlayEvent(System.Collections.Generic.List<System.Action> newValue) {
        var index = ManageComponentsLookup.StartPlayEvent;
        var component = (StartPlayEventComponent)CreateComponent(index, typeof(StartPlayEventComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStartPlayEvent() {
        RemoveComponent(ManageComponentsLookup.StartPlayEvent);
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

    static Entitas.IMatcher<ManageEntity> _matcherStartPlayEvent;

    public static Entitas.IMatcher<ManageEntity> StartPlayEvent {
        get {
            if (_matcherStartPlayEvent == null) {
                var matcher = (Entitas.Matcher<ManageEntity>)Entitas.Matcher<ManageEntity>.AllOf(ManageComponentsLookup.StartPlayEvent);
                matcher.componentNames = ManageComponentsLookup.componentNames;
                _matcherStartPlayEvent = matcher;
            }

            return _matcherStartPlayEvent;
        }
    }
}
