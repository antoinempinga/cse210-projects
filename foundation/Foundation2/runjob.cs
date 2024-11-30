using System;

class runJobs
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobName = "Fullstake Developer";
        job1._company = "Techmindset";
        job1._endYear = 2021;
        job1._startYear = 2016;

        Job job2 = new Job();
        job2._jobName = "Administrative Assistant";
        job2._company = "Mission DRC Mbuji-Mayi";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobName = "Multi Task Supervisor";
        job3._company = "Mapas tech";
        job3._startYear = 2023;
        job3._endYear = 2030;

        Job job4 = new Job();
        job4._jobName = "TCV (2years-Contract fixed term)";
        job4._company = "CENI DRC";
        job4._startYear = 2018;
        job4._endYear = 2020;

        Resume MyResume = new Resume();
        MyResume._name = "Ampikalgede Junior";
        MyResume._jobs.Add(job1);
        MyResume._jobs.Add(job2);
        MyResume._jobs.Add(job3);
        MyResume._jobs.Add(job4);

        MyResume.Dislplay();

    }
}