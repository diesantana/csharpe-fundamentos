
using AulaComposicaoStringBuilder.Entities;

DateTime dateTime = DateTime.Parse("21/06/2018 13:05:44");
string title = "Traveling to New Zealand";
string content = "I'm going to visit this wonderful country!";
int likes = 12;

Post post1 = new Post(dateTime, title, content, likes);
string comment1 = "Have a nice trip";
string comment2 = "Wow that's awesome!";

post1.Comments.Add(new Comment(comment1));
post1.Comments.Add(new Comment(comment2));

Console.WriteLine(post1);
Console.WriteLine("Comments:");
foreach (Comment comment in post1.Comments)
{
    Console.WriteLine(comment);
}

Console.WriteLine();

dateTime = DateTime.Parse("28/07/2018 23:14:19");
title = "Good night guys";
content = "See you tomorrow";
likes = 5;

Post post2 = new Post(dateTime, title, content, likes);
comment1 = "Good night";
comment2 = "May the Force be with you";

post2.Comments.Add(new Comment(comment1));
post2.Comments.Add(new Comment(comment2));

Console.WriteLine(post2);
Console.WriteLine("Comments:");
foreach (Comment comment in post2.Comments)
{
    Console.WriteLine(comment);
}
