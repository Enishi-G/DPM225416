namespace Factory.NetOptimized;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class Resume : Document
{
    // Factory Method implementation
    public override void CreatePages()
    {
        Pages =
        [
            new SkillsPage(),
            new EducationPage(),
            new ExperiencePage()
        ];
    }
}
