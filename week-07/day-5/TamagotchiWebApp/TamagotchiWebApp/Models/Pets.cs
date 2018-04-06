﻿using System;
using System.Collections.Generic;
using TamagotchiWebApp.Controllers;

namespace TamagotchiWebApp.Models
{
    public class Pets : IPets
    {
        public List<Pet> List = new List<Pet> {
            new Pet("Pet", new List<string>
        {
            "something",
            "something",
            "something",
        })
        };

        public Pet SelectedPet { get; set; }

        public void AddToList(Pet tamagotchi)
        {
            List.Add(tamagotchi);
        }

        public List<Pet> GetList()
        {
            return List;
        }

        public void SetSelectedPet(Pet chosenPet)
        {
            SelectedPet = chosenPet;
        }

        public Pet GetSelectedPet()
        {
            return SelectedPet;
        }
    }
}
