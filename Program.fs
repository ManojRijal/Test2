type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

type Director = {
    Name: string
    Movies: int
}
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

// Define the list of movies (already populated with movie instances)
let moviesList = [
    {Name = "CODA"; RunLength = 111; Genre = Drama; Director = {Name = "Sian Heder"; Movies = 9}; IMDBRating = 8.1}
    {Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = {Name = "Kenneth Branagh"; Movies = 23}; IMDBRating = 7.3}
    {Name = "Don’t Look Up"; RunLength = 138; Genre = Comedy; Director = {Name = "Adam McKay"; Movies = 27}; IMDBRating = 7.2}
    {Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = {Name = "Ryusuke Hamaguchi"; Movies = 16}; IMDBRating = 7.6}
    {Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = {Name = "Denis Villeneuve"; Movies = 24}; IMDBRating = 8.1}
    {Name = "King Richard"; RunLength = 144; Genre = Sport; Director = {Name = "Reinaldo Marcus Green"; Movies = 15}; IMDBRating = 7.5}
    {Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = {Name = "Paul Thomas Anderson"; Movies = 49}; IMDBRating = 7.4}
    {Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = {Name = "Guillermo Del Toro"; Movies = 22}; IMDBRating = 7.1}
]
//filter the proabale oscar winners by applying the filter function to fetch movies that have an IMDB rating greater than 7.4.
let probableOscarWinners = moviesList |> List.filter (fun movie -> movie.IMDBRating > 7.4)
