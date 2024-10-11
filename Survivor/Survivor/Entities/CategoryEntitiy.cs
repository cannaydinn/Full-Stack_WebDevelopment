namespace Survivor.Entities
{
    public class CategoryEntitiy : BaseEntity
    {
        private string name;
        private List<CompetitorEntitiy> competitors;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<CompetitorEntitiy> Competitors
        {
            get { return competitors; }
            set { competitors = value; }
        }

    }
}
