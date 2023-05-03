public class Job {
    public string _jobTitle;
    public string _jobCompany;
    public string _startYear;
    public string _endYear;

    public void display(){
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_startYear}-{_endYear}");
    }
}