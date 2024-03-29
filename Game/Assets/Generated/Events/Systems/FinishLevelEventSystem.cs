//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class FinishLevelEventSystem : Entitas.ReactiveSystem<ManageEntity> {

    readonly System.Collections.Generic.List<IFinishLevelListener> _listenerBuffer;

    public FinishLevelEventSystem(Contexts contexts) : base(contexts.manage) {
        _listenerBuffer = new System.Collections.Generic.List<IFinishLevelListener>();
    }

    protected override Entitas.ICollector<ManageEntity> GetTrigger(Entitas.IContext<ManageEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(ManageMatcher.FinishLevel)
        );
    }

    protected override bool Filter(ManageEntity entity) {
        return entity.isFinishLevel && entity.hasFinishLevelListener;
    }

    protected override void Execute(System.Collections.Generic.List<ManageEntity> entities) {
        foreach (var e in entities) {
            
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.finishLevelListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnFinishLevel(e);
            }
        }
    }
}
