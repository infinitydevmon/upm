using System.Collections.Generic;

namespace IVSendBox.Models
{
    public class CharacterModel
    {
        public string JsonKey;
        public string Name;

        public static List<CharacterModel> Molde = new List<CharacterModel>() { character1, character2 };

        public static CharacterModel character1
        {
            get { return new CharacterModel { JsonKey = "character1", Name = "Gwangmo" }; }
        }

        public static CharacterModel character2
        {
            get { return new CharacterModel { JsonKey = "character2", Name = "jung" }; }
        }
    }
}

