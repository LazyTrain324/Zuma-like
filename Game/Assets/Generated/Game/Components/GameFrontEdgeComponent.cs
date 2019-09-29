//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly FrontEdgeComponent frontEdgeComponent = new FrontEdgeComponent();

    public bool isFrontEdge {
        get { return HasComponent(GameComponentsLookup.FrontEdge); }
        set {
            if (value != isFrontEdge) {
                var index = GameComponentsLookup.FrontEdge;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : frontEdgeComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherFrontEdge;

    public static Entitas.IMatcher<GameEntity> FrontEdge {
        get {
            if (_matcherFrontEdge == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FrontEdge);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFrontEdge = matcher;
            }

            return _matcherFrontEdge;
        }
    }
}