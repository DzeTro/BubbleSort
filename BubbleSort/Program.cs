using System.Text;

public class Programm
{
    static void Main(string[] args)
    {
        // Zu sortierende Array 
        int[] arr = { 88, 55, 1, 6, 80, 99, 556, 700 };

        // Hilfsvariable
        int temp = 0;

        // Durchlauf Länge des Arrays
        for (int i = 0; i < arr.Length; i++)
        {
            // Durchlauf Inhalt des Arrays
            for (int j = 0; j < arr.Length - 1; j++)
            {

                // Abfrage ob der erste Index größer ist ls der nächste im Array
                if (arr[j] > arr[j + 1])
                {
                    // Zwischenspeichern in die Hilfsvariable und tauschen
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        // Augabe des Sortierten Arrays
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadKey();
    }
}