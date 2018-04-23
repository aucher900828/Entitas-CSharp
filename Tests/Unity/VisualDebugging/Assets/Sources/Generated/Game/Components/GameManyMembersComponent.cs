//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ManyMembersComponent manyMembers { get { return (ManyMembersComponent)GetComponent(GameComponentsLookup.ManyMembers); } }
    public bool hasManyMembers { get { return HasComponent(GameComponentsLookup.ManyMembers); } }

    public void AddManyMembers(string newField1, string newField2, string newField3, string newField4, string newField5, string newField6, string newField7, string newField8, string newField9, string newField10, string newField11, string newField12) {
        var index = GameComponentsLookup.ManyMembers;
        var component = CreateComponent<ManyMembersComponent>(index);
        component.field1 = newField1;
        component.field2 = newField2;
        component.field3 = newField3;
        component.field4 = newField4;
        component.field5 = newField5;
        component.field6 = newField6;
        component.field7 = newField7;
        component.field8 = newField8;
        component.field9 = newField9;
        component.field10 = newField10;
        component.field11 = newField11;
        component.field12 = newField12;
        AddComponent(index, component);
    }

    public void ReplaceManyMembers(string newField1, string newField2, string newField3, string newField4, string newField5, string newField6, string newField7, string newField8, string newField9, string newField10, string newField11, string newField12) {
        var index = GameComponentsLookup.ManyMembers;
        var component = CreateComponent<ManyMembersComponent>(index);
        component.field1 = newField1;
        component.field2 = newField2;
        component.field3 = newField3;
        component.field4 = newField4;
        component.field5 = newField5;
        component.field6 = newField6;
        component.field7 = newField7;
        component.field8 = newField8;
        component.field9 = newField9;
        component.field10 = newField10;
        component.field11 = newField11;
        component.field12 = newField12;
        ReplaceComponent(index, component);
    }

    public void RemoveManyMembers() {
        RemoveComponent(GameComponentsLookup.ManyMembers);
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

    static Entitas.IMatcher<GameEntity> _matcherManyMembers;

    public static Entitas.IMatcher<GameEntity> ManyMembers {
        get {
            if (_matcherManyMembers == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ManyMembers);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherManyMembers = matcher;
            }

            return _matcherManyMembers;
        }
    }
}
