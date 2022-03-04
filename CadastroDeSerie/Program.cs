using System;

    namespace CadastroDeSerie
    {

        class Program
        {

            static SerieRepository repository = new SerieRepository();
            static void Main(string[] args)
            {
                
                string userOption = GetUserOption();

                while (userOption.ToUpper() != "X")
                {
                    switch (userOption)
                    {
                        case "1":
                            SeriesList();
                            break;
                        case "2":
                            SeriesInsert();
                            break;
                        case "3":
                            SeriesUpdate();
                            break;
                        case "4":
                            SeriesDelete();
                            break;
                        case "5":
                            SeriesWatch();
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    userOption = GetUserOption();
                }

                Console.WriteLine("Thank you for be using our services!");
                Console.ReadLine();
            }

            private static void SeriesDelete()
            {
                Console.Write("Insert the id: ");
                int serieIndex = int.Parse(Console.ReadLine());
                Console.WriteLine("Are you sure about delete this serie? Y/N");
                string delete = Console.ReadLine();

                if (delete.ToUpper() == "Y")
                {
                    Console.WriteLine("Serie deleted with success!");
                    repository.Delete(serieIndex);
                }
                else
                {
                    GetUserOption();
                }
                
            }

            private static void SeriesWatch()
            {
                Console.Write("Insert the Id: ");
                int serieIndex = int.Parse(Console.ReadLine());

                var serie = repository.ReturnById(serieIndex);

                Console.WriteLine(serie);
            }

            private static void SeriesUpdate()
            {
                Console.Write("Insert the Id: ");
                int serieIndex = int.Parse(Console.ReadLine());

                foreach (int i in Enum.GetValues(typeof(Gender)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
                }

                Console.Write("Choose your option above: ");
			    int enterGender = int.Parse(Console.ReadLine());

                Console.Write("Type the Serie Title: ");
			    string enterTitle = Console.ReadLine();

                Console.Write("Type the Serie's first year: ");
			    int enterYear = int.Parse(Console.ReadLine());

                Console.Write("Type Description's Serie: ");
			    string enterDescription = Console.ReadLine();

                Serie updating = new Serie(id: serieIndex,
                gender: (Gender)enterGender,
                title: enterTitle,
                year: enterYear,
                description: enterDescription);

                repository.Update(serieIndex, updating);
            }

            private static void SeriesList()
            {
                Console.WriteLine("List: ");

			    var list = repository.List();

			    if (list.Count == 0)
			    {
				    Console.WriteLine("No records");
				    return;
			    }

			    foreach (var serie in list)
			    {
                    var deleted = serie.returningDeleted();
                
				    Console.WriteLine("#ID {0}: - {1} {2}", serie.returningId(), serie.returningTitle(), (deleted ? "*Deleted*" : ""));
			    }
            }

            private static void SeriesInsert()
            {
    			Console.WriteLine("Insert new Serie");

	    		foreach (int i in Enum.GetValues(typeof(Gender)))
		    	{
			    	Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
		    	}
		    	Console.Write("Choose the option:  ");
		    	int enterGender = int.Parse(Console.ReadLine());

			    Console.Write("Type the Serie Title: ");
			    string enterTitle = Console.ReadLine();

	    		Console.Write("Type the Serie's first year: ");
		    	int enterYear = int.Parse(Console.ReadLine());

			    Console.Write("Type Description's Serie: ");
	    		string enterDescription = Console.ReadLine();

			    Serie newSerie = new Serie(id: repository.NextId(),
                    gender: (Gender)enterGender,
                    title: enterTitle,
                    year: enterYear,
                    description: enterDescription);

    			repository.Insert(newSerie);
            }

            private static string GetUserOption()
            {
	    		Console.WriteLine();
                Console.WriteLine("  Welcome to DIO Series!!!  ");
                Console.WriteLine("  Choose your best option:  ");

                Console.WriteLine("       1- Series List       ");
                Console.WriteLine("     2- Insert new Serie    ");
                Console.WriteLine("       3- Update Serie      ");
                Console.WriteLine("       4- Delete Serie      ");
                Console.WriteLine("       5- Watch Serie       ");
                Console.WriteLine("      C- Clean Screen       ");
                Console.WriteLine("          X- Exit           ");
                Console.WriteLine();

                string userOption = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return userOption;
                
            }
        }
    }