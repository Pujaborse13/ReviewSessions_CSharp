// See https://aka.ms/new-console-template for more information
using ReviewSession_4;

class Program
{
    static void Main(string[] args)
    {
        //Q.1
        RegexProblems validateEmailId = new RegexProblems();
        validateEmailId.ValidateEMail();

        //Q.2
        RegexProblems extractPhoneNo = new RegexProblems();
        extractPhoneNo.ExtractPhoneNo();

        //Q.3
        RegexProblems validatePassword = new RegexProblems();
        validatePassword.ValidateStrongPassword();

       
        //Q.4
        RegexProblems extractDate = new RegexProblems();
        extractDate.ExtractDate();

        //Q.5
        RegexProblems replaceMultipleWhitespaces = new RegexProblems();
        replaceMultipleWhitespaces.ReplaceMultipleWhitespaces();

        //Q.6
        FileSizeCheck fileSizeCheck = new FileSizeCheck();
        fileSizeCheck.CheckFileSize();

        //Q.7
        TextFileOprations tfo1 = new TextFileOprations();
        tfo1.WriteInfile();

        TextFileOprations tfo2 = new TextFileOprations();
        tfo2.ReadFile();


        //Q.8
        JSONFileOperations jfo1 = new JSONFileOperations();
        jfo1.CreateFile();
        
        JSONFileOperations jfo2 = new JSONFileOperations();
        jfo2.WriteInJSONFile();

        JSONFileOperations jfo3 = new JSONFileOperations();
        jfo3.readJSONFile();


        
        

    }

}
