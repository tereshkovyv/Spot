using System.Collections.Generic;
using System.Linq;
using Spot.Data.Interfaces;
using Spot.Data.Models;

namespace Spot.Data.Mocks
{
    public class MockSocialObject : IAllSocialObjects
    {
        public IEnumerable<SocialObject> SocialObjects
        {
            get
            {
                return new List<SocialObject>()
                {
                    new SocialObject()
                    {
                        id = 1, name = "Игра по станциям на день космонавтики", presenter = "СПО 'Искорки'", img = "/img/1.jpg",
                        fullDescrtption = "Тут где-то полное описание",
                        shirtDescgription = "Игра по станциям на 1,5 часа для детей 10-15 лет",
                    },
                    new SocialObject()
                    {
                        id = 2, name = "Веселые старты", presenter = "СПО 'Sparks'", img = "/img/2.jfif",
                        fullDescrtption = "Тут где-то полное описание",
                        shirtDescgription = "Игра 'Веселые старты' на 1,5 часа для детей 6-9 лет"
                    },
                    new SocialObject()
                    {
                    id = 2, name = "Мастер-класс по играм на знакомство", presenter = "СПО 'ИСКРА'", img = "/img/3.jpeg",
                    fullDescrtption = "Тут где-то полное описание",
                    shirtDescgription = "Мастер-класс по играм на знакомство на 1,5 часа для детей 6-15 лет"
                    },
                    new SocialObject()
                    {
                        id = 2, name = "Мастер-класс по играм на знакомство", presenter = "СПО 'ИСКРА'", img = "/img/3.jpeg",
                        fullDescrtption = "Тут где-то полное описание",
                        shirtDescgription = "Просто копия предыдущей карточки "
                    }
                };
            }
        }

        public IEnumerable<SocialObject> GetFavorite
        {
            get => SocialObjects.Take(2);
            set{}
        }
    }
}