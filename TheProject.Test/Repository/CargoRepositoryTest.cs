using TheProject.API.Model.Entities;

namespace TheProject.Test.Repository
{
    public class CargoRepositoryTest : GenericRepositoryTest<Cargo>
    {
        public CargoRepositoryTest() : base()
        {
            GenerateSet();
        }

        protected override void GenerateSet()
        {
            return;
        }
    }
}