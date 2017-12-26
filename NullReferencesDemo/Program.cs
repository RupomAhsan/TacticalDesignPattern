using NullReferencesDemo.Application.Implementation;
using NullReferencesDemo.Domain.Implementation;
using NullReferencesDemo.Infrastructure.Implementation;
using NullReferencesDemo.Presentation.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui =
                new UserInterface(
                    new ApplicationServices(
                        new DomainServices(
                            new UserRepository(),
                            new ProductRepository())));

            while (ui.ReadCommand())
            {
                ui.ExecuteCommand();
            }
        }
    }
}
