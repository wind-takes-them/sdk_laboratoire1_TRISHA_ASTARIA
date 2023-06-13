namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer (string NoteAlphabetique)
        {
            var returnStr = "Entree Invalide";


            NoteAlphabetique = NoteAlphabetique.ToUpper().Trim ();
            switch (NoteAlphabetique)
            {
                case "A":
                    returnStr = "LA";
                    break;
                case "B":
                    returnStr = "SI";
                    break;
                case "C":
                    returnStr = "DO";
                    break;
                case "D":
                    returnStr = "RE";
                    break;
                case "E":
                    returnStr = "MI";
                    break;
                case "F":
                    returnStr = "FA";
                    break;
                case "G":
                    returnStr = "SOL";
                    break;
            }
            
            return returnStr;
        }



    }
}