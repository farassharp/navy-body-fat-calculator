using Calculator.Models.Enum;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(IApplicationBuilder aptBuilder)
        {
            using (var scope = aptBuilder.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<CalculatorContext>();
                context.Database.EnsureCreated();
                if (!context.Genders.Any())
                {
                    context.Genders.AddRange(new List<Gender> {
                        new Gender { ID = GenderEnum.male, Description = "Hombre" },
                        new Gender { ID = GenderEnum.female, Description = "Mujer" }
                    });
                    context.SaveChanges();
                }
                if (!context.Formulas.Any())
                {
                    context.Formulas.AddRange(new List<Formula>
                    {
                        new Formula { GenderID = GenderEnum.male, Const1 = 495m, Const2 = 1.0324m, Const3 = 0.19077m, Const4 = 0.15456m, Const5 = 450m },
                        new Formula { GenderID = GenderEnum.female, Const1 = 495m, Const2 = 1.29579m, Const3 = 0.35004m, Const4 = 0.22100m, Const5 = 450m }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
