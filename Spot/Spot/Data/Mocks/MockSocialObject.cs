/*using System.Collections.Generic;
using System.Linq;
using Spot.Data.Interfaces;
using Spot.Data.Models;

namespace Spot.Data.Mocks
{
    public class MockSocialObject : IAllSocialObjects
    {
        public IEnumerable<SocialObject> GetAllObjectsObjects
        {
            get
            {
                return new List<SocialObject>()
                {
                    new SocialObject()
                    {
                        Id = 1, Name = "Игра по станциям на день космонавтики", Presenter = "СПО 'Искорки'",
                        FullDescription = "Тут где-то полное описание",
                        ShirtDescription = "Игра по станциям на 1,5 часа для детей 10-15 лет",
                    },
                    new SocialObject()
                    {
                        Id = 2, Name = "Веселые старты", Presenter = "СПО 'Sparks'",
                        FullDescription = "Тут где-то полное описание",
                        ShirtDescription = "Игра 'Веселые старты' на 1,5 часа для детей 6-9 лет"
                    },
                    new SocialObject()
                    {
                    Id = 2, Name = "Мастер-класс по играм на знакомство", Presenter = "СПО 'ИСКРА'",
                    FullDescription = "Тут где-то полное описание",
                    ShirtDescription = "Мастер-класс по играм на знакомство на 1,5 часа для детей 6-15 лет"
                    },
                    new SocialObject()
                    {
                        Id = 2, Name = "Мастер-класс по играм на знакомство", Presenter = "СПО 'ИСКРА'",
                        FullDescription = "Тут где-то полное описание",
                        ShirtDescription = "Просто копия предыдущей карточки "
                    }
                };
            }
            set => throw new System.NotImplementedException();
        }


        public IEnumerable<SocialObject> GetFavoriteObjects => GetAllObjectsObjects.Take(2); 
        public IEnumerable<SocialObject> GetMySocialObjects => GetAllObjectsObjects.Take(2); 
    }
}*/