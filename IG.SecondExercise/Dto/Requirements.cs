using IG.SecondExercise.Enum;

namespace IG.SecondExercise.Dto
{
    public class Requirements : ResourceItem
    {
        public Requirements(ResourceTypes resourceType, int amount) : base(resourceType, amount)
        {
        }
    }
}