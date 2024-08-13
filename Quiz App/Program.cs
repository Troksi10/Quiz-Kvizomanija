using Quiz_App;

Question[] quoestions =
[
    new Question("What is the capital of MACEDONIA?",
    ["Belgrade","Sofia","Skopje","Athens"],
    2
    ),
    new Question("What can be broken, but is never held",
    ["A promise","Glass of Wine","The TV","Car"],
    0),
    new Question("It belongs to you, but your friends use it more. What is it",
    ["Your Car","Your Name","Your money","Your girlfriend"],1),
];

Quiz myQuiz = new Quiz(quoestions);
myQuiz.StartQuiz();

Console.ReadLine();
