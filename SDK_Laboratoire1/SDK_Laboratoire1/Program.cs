using LibrairieConversionNote;


ConversionAlphabetiqueToNote conversion = new ConversionAlphabetiqueToNote();

while (true)
{
    Console.WriteLine("Selectionnez la conversion a faire.\n NOTE : Alphabetique vers note");
    var typeConversion = Console.ReadLine();
    typeConversion = typeConversion.ToUpper().Trim();

    if (typeConversion == "NOTE") {
        while (true)
        {
            Console.WriteLine("Entrez la note alphabetique a convertir: ");
            var noteAConvertir = Console.ReadLine();

            var noteConvertie = conversion.Transformer(noteAConvertir);
            Console.WriteLine(noteConvertie);
        }
    }
}