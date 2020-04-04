using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Food
    {
        public string Name { get; }

        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; set; }
        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; set; }
        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get; set; }
        /// <summary>
        /// Калории за 100 грамм продукта
        /// </summary>
        public double Calories { get; }


        public Food(string name) : this(name, 0, 0, 0, 0)
        {
            

        }

        public Food(string name, double calories, double proteins,
                    double carbohydrates, double fats)
        {
            // TODO: проверка

            Name = name ?? throw new ArgumentNullException(nameof(name));
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Carbohydrates = carbohydrates / 100.0;
            Fats = fats / 100;


        }

        public override string ToString()
        {
            return Name;
        }
    }
}
