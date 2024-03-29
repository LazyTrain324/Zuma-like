//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public TouchPositionComponent touchPosition { get { return (TouchPositionComponent)GetComponent(InputComponentsLookup.TouchPosition); } }
    public bool hasTouchPosition { get { return HasComponent(InputComponentsLookup.TouchPosition); } }

    public void AddTouchPosition(UnityEngine.Vector2 newValue) {
        var index = InputComponentsLookup.TouchPosition;
        var component = (TouchPositionComponent)CreateComponent(index, typeof(TouchPositionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTouchPosition(UnityEngine.Vector2 newValue) {
        var index = InputComponentsLookup.TouchPosition;
        var component = (TouchPositionComponent)CreateComponent(index, typeof(TouchPositionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTouchPosition() {
        RemoveComponent(InputComponentsLookup.TouchPosition);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherTouchPosition;

    public static Entitas.IMatcher<InputEntity> TouchPosition {
        get {
            if (_matcherTouchPosition == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.TouchPosition);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherTouchPosition = matcher;
            }

            return _matcherTouchPosition;
        }
    }
}
