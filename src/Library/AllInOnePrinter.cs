
//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Cumple con SRP 
    /// Cumple con exprt ya que es responsable de las impresoiones.
    /// Cumple con OCP ya que es abierto a futuras extensiones(ya que se pueden agregar mas "canales de impresion") y cerrado a modificaciones.
    /// </summary>
    public enum Destination
    {
        Console,
        File
    }

    public class AllInOnePrinter
    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
            }
        }
    }
=======
//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;
namespace Full_GRASP_And_SOLID.Library
{
    public class AllInOnePrinter
    {
        public void PrintConsoleRecipe(Recipe recipe) => Console.WriteLine(recipe.GetTextToPrint());
        public void PrintFileRecipe(Recipe recipe) => File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
    }
}