
using System.Collections.Generic;

public class AppointmentQueue
{
    private Queue<string> queue;

    public AppointmentQueue() {
        queue = new Queue<string>();
    }

    public void AddPatient(string patientName) {
        queue.Enqueue(patientName);
    }

    public string GetNextPatient() {
        return queue.Count > 0 ? queue.Dequeue() : "Kuyruk boş.";
    }

    public string GetBackPatient() {
        return queue.Count > 0 ? queue.Peek() : "Kuyruk boş."; 
    }

    public int WaitingCount() {
        return queue.Count;
    }
}
