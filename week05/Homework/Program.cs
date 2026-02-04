using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Math Assignment:
        -Student's Name
        -Topic
        -Textbook Section
        -Problems in the section
        
        Constructor:
        - Value for each item

        Method:
        - Return assignment summary (student's name, topic)
        - Display Math Hw list (section numbers and problems)
        */
        
        /*
        Writing Assignment:
        -Student's Name
        -Topic
        -Assignment Title
        
        Constructor:
        - Value for each item

        Method:
        - Return assignment summary (studen't name, topic)
        - Display Writing Info (title, student's name)
        */

        MathAssignment mathAssignment1 = new MathAssignment("Samuel Bennett", "Multiplication", "Section 7.1", "8-9");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment2 = new WritingAssignment("Mary Jane", "Grammar", "The death of the semi-colon");
        Console.WriteLine(writingAssignment2.GetSummary());
        Console.WriteLine(writingAssignment2.GetWritingInfo());
    }
}