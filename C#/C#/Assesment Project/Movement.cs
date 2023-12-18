using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace C_.Assesment_Project
{
    internal class Movement
    {
        static void Main(string[] args)
        {
            var mapDimensions = TakeMapDimensionsFromUser();
            var movementCoordinates = TakeMovementCoordinatesFromUser();
            var lifeForms = TakeLifeFormsFromUser();

            CalculateAndReportPath(mapDimensions, GenerateRootCoordinates(movementCoordinates, lifeForms));
        }
        private static int[] TakeMapDimensionsFromUser()
        {
            var mapDimensions = new int[2];

            Console.WriteLine("Please enter dimensions of map in the order width(w) and height(h)");

            var widthInput = Console.ReadLine();
            var heightInput = Console.ReadLine();
            var width = Convert.ToInt32(widthInput);
            var height = Convert.ToInt32(heightInput);

            mapDimensions[0] = width;
            mapDimensions[1] = height;

            return mapDimensions;
        }

        private static List<int> TakeMovementCoordinatesFromUser()
        {
            var movementCoordinatesList = new List<int>();

            Console.WriteLine("Please enter movement coordinates in the order X - Y. When you're done please enter 'DONE'!");

            var input = "";
            do
            {
                input = Console.ReadLine().ToUpper();
                if (input!="DONE")
                    movementCoordinatesList.Add(Convert.ToInt32(input));
                
            } while (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input) || !input.Equals("DONE"));

            return movementCoordinatesList;
        }

        private static int TakeLifeFormsFromUser()
        {
            Console.WriteLine("Please enter a life form press '1' for Human \npress '2' for Alien");
            var lifeForm = Console.ReadLine();
            return Convert.ToInt32(lifeForm);
        }

        private static int[,] GenerateRootCoordinates(List<int> coordinates, int lifeForm)
        {
            List<int> tempList = coordinates;
            foreach(var a in tempList)
            {
                Console.WriteLine(a);
            }

            var sizeOfArray = tempList.Count/2;
            var arrayRootCoordinates = new int[sizeOfArray,2];
            var index = 0;

            while (tempList.Count >= 2)
            {

                if (lifeForm == 1)
                {
                    arrayRootCoordinates[index, 0] = tempList[0];
                    arrayRootCoordinates[index, 1] = tempList[1];
                }
                else
                {
                    arrayRootCoordinates[index, 0] = tempList[1];
                    arrayRootCoordinates[index, 1] = tempList[0];
                }

                tempList.RemoveAt(0);
                tempList.RemoveAt(0);

                index++;
            }


            return arrayRootCoordinates;
        }

        private static List<int> CalculateAndReportPath(int[] mapDimensions, int[,] rootCoordinates)
        {
            var pathReport = new int[rootCoordinates.Length, 2];
            var mapWidth = mapDimensions[0];
            var mapHeight = mapDimensions[1];

            var x = 0;
            var y = 0;

            Console.WriteLine("Report Path:");
            for (int i = 0; i < rootCoordinates.Length; i++)
            {
                if (mapWidth > rootCoordinates[i, 0] && mapHeight > rootCoordinates[i, 1])
                {
                    x += rootCoordinates[i, 0];
                    y += rootCoordinates[i, 1];

                    if (y> mapHeight)
                    {
                        y = 0;
                    }
                    if (x > mapWidth)
                    {
                        y = 0;
                    }

                    Console.WriteLine("[{0},{1}]", x, y);
                }

            }

            return null;
        }
    }
}
