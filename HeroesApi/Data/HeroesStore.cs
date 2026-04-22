using System.Data.Common;
using System.Runtime.CompilerServices;
using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore
{
    public static List<Hero> Heroes { get; } = new()
    {
        new Hero
        {
            Id = 1,
            Name = "человек-паук",
            RealName = "Питер Паркер",
            Universe = Universe.Marvel,
            PowerLevel = 75,
            Powers = new() {"паутина" , "лазание по стенам" , "паучье чутье"},
            Weapon = new() {Name = "Паутиностерл" , IsRanged = true},
            InternalNotes = "Любимый герой редактора"
        },
        new Hero
        {
            Id = 2,
            Name = "бэтмен",
            RealName = "брюс уэйн",
            Universe = Universe.Dc,
            PowerLevel = 70,
            Powers = new() {"интеллект" , "боевые искусства" , "технологии"},
            Weapon = new() {Name = "Бэтаранг" , IsRanged = true},
            InternalNotes = "Без суперсл , только денбги и упорство"
        },
        new Hero
        {
            Id = 3,
            Name = "железный человек",
            RealName = "тони старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() {"броня" , "полет" , "интеллект" , "лазеры"},
            Weapon = new() {Name = "костюм марк 50" , IsRanged = true},
            InternalNotes = "я - железный человек"
        },
        new Hero
        {
            Id = 4,
            Name = "грут",
            RealName = "гурт",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new() {"регенерация" , "управлением деревом" , "суперсила" },
            Weapon = new() {Name = "ветви" , IsRanged =false},
            InternalNotes = "я есть грут"
        },

        new Hero
        {
            Id = 5,
            Name = "железный человек",
            RealName = "тони старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() {"броня" , "полет" , "интеллект" , "лазеры"},
            Weapon = new() {Name = "костюм марк 50" , IsRanged = false},
            InternalNotes = "я - железный человек"
        },
        new Hero
        {
            Id = 6,
            Name = "железный человек",
            RealName = "тони старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() {"броня" , "полет" , "интеллект" , "лазеры"},
            Weapon = new() {Name = "костюм марк 50" , IsRanged = false },
            InternalNotes = "я - железный человек"
        },
        new Hero
        {
            Id = 7,
            Name = "железный человек",
            RealName = "тони старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() {"броня" , "полет" , "интеллект" , "лазеры"},
            Weapon = new() {Name = "костюм марк 50" , IsRanged = true},
            InternalNotes = "я - железный человек"
        },

    };
}