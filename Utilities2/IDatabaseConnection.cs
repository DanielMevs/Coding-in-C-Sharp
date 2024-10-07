namespace Utilities2;

public interface IDatabaseConnection
{
    Person GetById(int id);
    void Write(int id, Person person);
}
