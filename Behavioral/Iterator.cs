namespace DesignPatterns.Behavioral;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}

public class Song
{
    public string Title { get; }
    public string Artist { get; }

    public Song(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }
}


public class SongCollection : IAggregate<Song>
{
    private List<Song> _songs = new List<Song>();

    public void AddSong(Song song)
    {
        _songs.Add(song);
    }

    public Song GetSong(int index)
    {
        return _songs[index];
    }

    public int Count => _songs.Count;

    public IIterator<Song> CreateIterator()
    {
        return new SongIterator(this);
    }
}


public class SongIterator : IIterator<Song>
{
    private readonly SongCollection _collection;
    private int _position = 0;

    public SongIterator(SongCollection collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _position < _collection.Count;
    }

    public Song Next()
    {
        if (!HasNext())
            throw new InvalidOperationException("No more songs!");

        Song song = _collection.GetSong(_position);
        _position++; 
        return song;
    }
}

public class PlaylistCollection : IAggregate<Song>
{
    private Song[] _songs;
    private int _index = 0;

    public PlaylistCollection(int capacity)
    {
        _songs = new Song[capacity];
    }

    public void AddSong(Song song)
    {
        if (_index >= _songs.Length)
            throw new InvalidOperationException("Playlist is full!");
        _songs[_index++] = song;
    }

    public Song GetSong(int index)
    {
        return _songs[index];
    }

    public int Count => _index;

    public IIterator<Song> CreateIterator()
    {
        return new PlaylistIterator(this);
    }
}

public class PlaylistIterator : IIterator<Song>
{
    private readonly PlaylistCollection _collection;
    private int _position = 0;

    public PlaylistIterator(PlaylistCollection collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _position < _collection.Count;
    }

    public Song Next()
    {
        if (!HasNext())
            throw new InvalidOperationException("No more songs!");

        Song song = _collection.GetSong(_position);
        _position++;
        return song;
    }
}



