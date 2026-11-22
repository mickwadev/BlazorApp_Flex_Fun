namespace BlazorApp_Flex_Fun;

// Jaki jest main axis i cross axis?
public enum FlexDirection
{
    Row = 1,
    Column = 2,
    RowReverse = 3,
    ColumnReverse = 4
}


// Jak układają się elementy w main axis w orbębie jednego rzędu?
public enum JustifyContent
{ 
    Center = 1,
    SpaceBetween =2,
    SpaceAround =3,
    FlexStart = 4,
    FlexEnd = 5
}

// Jak układają się wszystkie rzędy?
public enum AlignContent
{
    Center = 1,
    SpaceBetween = 2,
    SpaceAround = 3,
    FlexStart = 4,
    FlexEnd = 5,
    Stretch = 6
}

// jak układają się element w cross axis?
public enum AlignItems
{ 
    Stretch=1,
    Center =2,
    FlexStart=3,
    FlexEnd=4
}
