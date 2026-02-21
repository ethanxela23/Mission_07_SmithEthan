CREATE TABLE Movies (
    MovieId INTEGER PRIMARY KEY AUTOINCREMENT,
    Category TEXT NOT NULL,
    Title TEXT NOT NULL,
    Year INTEGER NOT NULL,
    Director TEXT NOT NULL,
    Rating TEXT NOT NULL,
    Edited INTEGER,
    LentTo TEXT,
    Notes TEXT
);