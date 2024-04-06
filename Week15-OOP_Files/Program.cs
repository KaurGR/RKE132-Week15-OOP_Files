using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Movie> myMovies = new List<Movie>();
        string[] data = GetDataFromMyFile();
        // ReadDataFromArray(data);

        foreach (string line in data)
        {
            string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            Movie newMovie = new Movie(tempArray[0], tempArray[1]); // Adjusted index to access the year correctly
            myMovies.Add(newMovie);
        }

        foreach (Movie movie in myMovies)
        {
            Console.WriteLine($"One of my favourite movies {movie.Title} was released in {movie.Year}.");
        }
    }

    static string[] GetDataFromMyFile()
    {
        string filePath = @"C:\Users\kaurg\OneDrive\Desktop\ProgeAlgkursus\Week15-OOP_Files\movies.txt";
        return File.ReadAllLines(filePath);
    }

    static void ReadDataFromArray(string[] someArray)
    {
        foreach (string line in someArray)
        {
            Console.WriteLine(line);
        }
    }
}

class Movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}