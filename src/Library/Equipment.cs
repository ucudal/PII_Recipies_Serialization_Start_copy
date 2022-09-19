//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace Recipies
{
    public class Equipment : IJsonConvertible
    {
        [JsonConstructor]
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public Equipment(string json)
        {
            this.LoadFromJson(json);
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }

        public string ConvertToJson()
        {
            throw new System.NotImplementedException();
        }

        public void LoadFromJson(string json)
        {
            throw new System.NotImplementedException();
        }
    }
}