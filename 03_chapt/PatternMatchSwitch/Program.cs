using PatternMatchSwitch;

var animals = new Animal?[] {
    new Cat {Name = "Mr Mittens", DOB=new(year:2022, month: 8, day: 23), IsDomestic = true, Legs = 4 },
    new Cat {Name = "Mufasa", DOB=new(year:1994, month: 6, day: 12)},
    new Spider {Name = "Sid Vicious", DOB=new(year: 2024, month: 4, day: 17), IsPoisonous = true, Legs= 8 },
    new Spider {Name = "Cap'n Furry legs", DOB=new(year: 2024, month: 3, day: 9), IsPoisonous = false, Legs= 8 }
};

// loop with switch
foreach (Animal? animal in animals)
{
    // string message;

    // switch (animal)
    // {
    //     // could be written concisely as: case Cat {Legs: 4} fourLeggedCat:
    //     case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
    //         message = $"The cat named {fourLeggedCat.Name} has four legs.";
    //         break;
    //     case Cat WildCat when WildCat.IsDomestic == false:
    //         message = $"The non-domestic cat is named {WildCat.Name}.";
    //         break;
    //     case Cat cat:
    //         message = $"The cat is named {cat.Name}.";
    //         break;
    //     case Spider spider when spider.IsPoisonous:
    //         message = $"The spider {spider.Name} is poisonous. RUN!";
    //         break;
    //     case null:
    //         message = $"The animal is null.";
    //         break;
    //     default:
    //         message = $"{animal.Name} is a {animal.GetType().Name}.";
    //         break;
    // }

    // simplifying switch
    string message = animal switch
    {
        // could be written concisely as: case Cat {Legs: 4} fourLeggedCat:
        Cat fourLeggedCat when fourLeggedCat.Legs == 4 => $"The cat named {fourLeggedCat.Name} has four legs.",
        Cat WildCat when WildCat.IsDomestic == false => $"The non-domestic cat is named {WildCat.Name}.",
        Cat cat => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsPoisonous => $"The spider {spider.Name} is poisonous. RUN!",
        null => $"The animal is null.",
        _ => $"{animal.Name} is a {animal.GetType().Name}."
    };

    WriteLine($"Switch Message: {message}");

}