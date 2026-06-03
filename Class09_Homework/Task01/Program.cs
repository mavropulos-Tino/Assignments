using File = System.IO.File;

namespace Task01;
internal class Program
{
    static void Main(string[] args)
    {
        //Create a folder named "Files".
        //Create a file name "names.txt".
        #region Task01
        string rootPath = @"..\..\..\";
        string folderPath = $@"{rootPath}Files";
        string filePath = $@"{folderPath}\names.txt";

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
        #endregion

        //Read the file created in the previous task named "names.txt".
        //Ask the user to enter some names and save these names in the file that we previously created.
        #region Task02
        try
        {

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                Console.WriteLine("Input names into the text document (type 'x' to stop):");

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input.ToLower() == "x")
                    {
                        Console.WriteLine("Stopping...");
                        break;
                    }

                    writer.WriteLine(input);

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing in file. Error: {ex.Message}");
        }
        #endregion

        //Read the file created in the previous task name "names.txt".
        //Go thru the file content and filter out all the names that start with A.If there are any names create a new file named "namesStartingWith_A.txt" that will contains the filtered content and if there is no names that start with A do nothing.
        //Do this for all the letters in the alphabet.

        //Redo Task 3 but if the file already exists add the new names in the file and keep the already existing names.
        #region Task03 & Task04
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string filteredNamesFolderPath = $@"{folderPath}\FilteredNames";
                    char firstLetter = char.ToUpper(line[0]);

                    if (!Directory.Exists(filteredNamesFolderPath))
                    {
                        Directory.CreateDirectory(filteredNamesFolderPath);
                    }

                    string filteredFilePath = $@"{filteredNamesFolderPath}\namesStartingWith_{firstLetter}.txt";

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filteredFilePath, true))
                        {
                            writer.WriteLine(line);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error writing in file. Error: {ex.Message}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file. Error: {ex.Message}");
        }
        #endregion



        // Final reading of the names in names.txt
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file. Error: {ex.Message}");
        }
    }
}