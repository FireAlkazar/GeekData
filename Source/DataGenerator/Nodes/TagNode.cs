using DataGenerator.Entities;

namespace DataGenerator.Nodes
{
    public sealed class TagNode : Node
    {
        private const string Suffix = "TagNode";

        public TagNode(NodeRow node)
        {
            IdNode = $"{node.Tag}{Suffix}";
            Label = $"{node.Tag}";
        }

        public override string IdNode { get; }
        public override string Label { get; }
        public override int Level { get; } = 1;

        public override string ToString()
        {
            var items1 = new string(';', RepositoryInfoEntity.Captions().Count - 1);
            var items2 = new string(';', CourseEntity.Captions().Count - 1);
            var items3 = new string(';', UserEntity.Captions().Count - 1);

            return $"{IdNode};{Label}; {Level}; {items1}; {items2}; {items3}";
        }
    }
}
