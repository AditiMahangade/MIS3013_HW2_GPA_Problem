// Aditi Mahangade
// MIS 3013 HW2 Grade Problem

double overGPADb1 = 0;

string outMesStr;
string inputMesStr;

// Accounting, Marketing, Economics, and MIS
// A, B, C, D, F

// accounting
int accCreditHoursInt = 3;
int accPointValDb1 = -1;
char accLetterGradCh = 'E';
double accGradeDb1 = 1;
outMesStr = "Please input the grade of accounting: ";
Console.WriteLine(outMesStr);
inputMesStr = Console.ReadLine();
accGradeDb1 = Convert.ToDouble(inputMesStr);
if (accGradeDb1 >= 90)
{
    accLetterGradCh = 'A';
    accPointValDb1 = 4;
}
else if (accGradeDb1 >= 80)
{
    accLetterGradCh = 'B';
    accPointValDb1 = 3;
}
else if (accGradeDb1 >= 70)
{
    accLetterGradCh = 'C';
    accPointValDb1 = 2;
}
else if (accGradeDb1 >= 60)
{
    accLetterGradCh = 'D';
    accPointValDb1 = 1;
}
else
{
    accLetterGradCh = 'F';
    accPointValDb1 = 0;
}

// Marketing

int markCreditHoursInt = 3;
int markPointValDb1 = -1;
char markLetterGradCh = 'E';
double markGradeDb1 = 1;
outMesStr = "Please input the grade of marketing: ";
Console.WriteLine(outMesStr);
inputMesStr = Console.ReadLine();
markGradeDb1 = Convert.ToDouble(inputMesStr);
if (markGradeDb1 >= 90)
{
    markLetterGradCh = 'A';
    markPointValDb1 = 4;
}
else if (markGradeDb1 >= 80)
{
    markLetterGradCh = 'B';
    markPointValDb1 = 3;
}
else if (markGradeDb1 >= 70)
{
    markLetterGradCh = 'C';
    markPointValDb1 = 2;
}
else if (markGradeDb1 >= 60)
{
    markLetterGradCh = 'D';
    markPointValDb1 = 1;
}
else
{
    markLetterGradCh = 'F';
    markPointValDb1 = 0;
}

// Economics

int econCreditHoursInt = 3;
int econPointValDb1 = -1;
char econLetterGradCh = 'E';
double econGradeDb1 = 1;
outMesStr = "Please input the grade of economics: ";
Console.WriteLine(outMesStr);
inputMesStr = Console.ReadLine();
econGradeDb1 = Convert.ToDouble(inputMesStr);
if (econGradeDb1 >= 90)
{
    econLetterGradCh = 'A';
    econPointValDb1 = 4;
}
else if (econGradeDb1 >= 80)
{
    econLetterGradCh = 'B';
    econPointValDb1 = 3;
}
else if (econGradeDb1 >= 70)
{
    econLetterGradCh = 'C';
    econPointValDb1 = 2;
}
else if (econGradeDb1 >= 60)
{
    econLetterGradCh = 'D';
    econPointValDb1 = 1;
}
else
{
    econLetterGradCh = 'F';
    econPointValDb1 = 0;
}

// MIS

int misCreditHoursInt = 3;
int misPointValDb1 = -1;
char misLetterGradCh = 'E';
double misGradeDb1 = 1;
outMesStr = "Please input the grade of MIS: ";
Console.WriteLine(outMesStr);
inputMesStr = Console.ReadLine();
misGradeDb1 = Convert.ToDouble(inputMesStr);
if (misGradeDb1 >= 90)
{
    misLetterGradCh = 'A';
    misPointValDb1 = 4;
}
else if (misGradeDb1 >= 80)
{
    misLetterGradCh = 'B';
    misPointValDb1 = 3;
}
else if (misGradeDb1 >= 70)
{
    misLetterGradCh = 'C';
    misPointValDb1 = 2;
}
else if (accGradeDb1 >= 60)
{
    misLetterGradCh = 'D';
    misPointValDb1 = 1;
}
else
{
    misLetterGradCh = 'F';
    misPointValDb1 = 0;
}

// overall GPA
overGPADb1 = (accPointValDb1 * accCreditHoursInt + markPointValDb1 * markCreditHoursInt + econPointValDb1 * econCreditHoursInt + misPointValDb1 * misCreditHoursInt) * 1.0 / (accCreditHoursInt + markCreditHoursInt + econCreditHoursInt + misCreditHoursInt);

outMesStr = "The letter grades:";
Console.WriteLine("\n");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Accounting: {accLetterGradCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Marketing: {markLetterGradCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Economics: {econLetterGradCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of MIS: {misLetterGradCh}");
Console.WriteLine(outMesStr);

// overall GPA
outMesStr = String.Format($"The GPA: {overGPADb1:F2}");
Console.WriteLine();
Console.WriteLine(outMesStr);


Console.ReadLine();





