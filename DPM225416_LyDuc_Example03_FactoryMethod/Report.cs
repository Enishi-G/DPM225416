namespace Factory.NetOptimized;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
public class Report : Document
{
    // Factory Method implementation
    public override void CreatePages()
    {
        Pages =
        [
            new IntroductionPage(),
            new ResultsPage(),
            new ConclusionPage(),
            new SummaryPage(),
            new BibliographyPage()
        ];
    }
}
