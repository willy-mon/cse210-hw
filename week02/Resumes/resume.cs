using System;

public class Resume
{
    public string _name;

    // Asegurate de iniciar tu lista a una nueva lista antes de que la uses 
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        //Mira el uso de el tipo de dato configurable "Job" en este ciclo.
        foreach (Job job in _jobs)
        {
            //Esto llama el método Display en cada "job".
            job.Display();
        }
    }
}