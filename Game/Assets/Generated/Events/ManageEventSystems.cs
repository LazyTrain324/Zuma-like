//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class ManageEventSystems : Feature {

    public ManageEventSystems(Contexts contexts) {
        Add(new FinishLevelEventSystem(contexts)); // priority: 0
        Add(new LevelPlayEventSystem(contexts)); // priority: 0
        Add(new StartLevelEventSystem(contexts)); // priority: 0
    }
}
