CREATE TABLE "People"(
    "ID" INT NOT NULL,
    "Name" NVARCHAR(255) NOT NULL,
    "Surname" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "People" ADD CONSTRAINT "people_id_primary" PRIMARY KEY("ID");
CREATE TABLE "Users"(
    "ID" INT NOT NULL,
    "PersonID" INT NOT NULL,
    "Emai" NVARCHAR(255) NOT NULL,
    "Password" NVARCHAR(255) NOT NULL,
    "PhoneNumber" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "Users" ADD CONSTRAINT "users_id_primary" PRIMARY KEY("ID");
CREATE TABLE "Books"(
    "ID" INT NOT NULL,
    "Title" NVARCHAR(255) NOT NULL,
    "Year" DATE NOT NULL,
    "Genre" NVARCHAR(255) NOT NULL,
    "IsLoaned" BIT NOT NULL,
    "Position" NVARCHAR(255) NOT NULL,
    "Pages" INT NOT NULL
);
ALTER TABLE
    "Books" ADD CONSTRAINT "books_id_primary" PRIMARY KEY("ID");
CREATE TABLE "Dvds"(
    "ID" INT NOT NULL,
    "Title" NVARCHAR(255) NOT NULL,
    "Year" DATE NOT NULL,
    "Genre" NVARCHAR(255) NOT NULL,
    "IsLoaned" BIT NOT NULL,
    "Position" NVARCHAR(255) NOT NULL,
    "Duration" INT NOT NULL
);
ALTER TABLE
    "Dvds" ADD CONSTRAINT "dvds_id_primary" PRIMARY KEY("ID");
CREATE TABLE "Author_Book"(
    "ID" INT NOT NULL,
    "AuthorID" INT NOT NULL,
    "BookID" INT NOT NULL
);
ALTER TABLE
    "Author_Book" ADD CONSTRAINT "author_book_id_primary" PRIMARY KEY("ID");
CREATE TABLE "Author_Dvd"(
    "ID" INT NOT NULL,
    "AuthorID" INT NOT NULL,
    "DvdID" INT NOT NULL
);
ALTER TABLE
    "Author_Dvd" ADD CONSTRAINT "author_dvd_id_primary" PRIMARY KEY("ID");
ALTER TABLE
    "Author_Book" ADD CONSTRAINT "author_book_bookid_foreign" FOREIGN KEY("BookID") REFERENCES "Books"("ID");
ALTER TABLE
    "Users" ADD CONSTRAINT "users_personid_foreign" FOREIGN KEY("PersonID") REFERENCES "People"("ID");
ALTER TABLE
    "Author_Dvd" ADD CONSTRAINT "author_dvd_authorid_foreign" FOREIGN KEY("AuthorID") REFERENCES "People"("ID");
ALTER TABLE
    "Author_Book" ADD CONSTRAINT "author_book_authorid_foreign" FOREIGN KEY("AuthorID") REFERENCES "People"("ID");
ALTER TABLE
    "Author_Dvd" ADD CONSTRAINT "author_dvd_dvdid_foreign" FOREIGN KEY("DvdID") REFERENCES "Dvds"("ID");