using DataGenerator.Entities;

namespace DataGenerator.Nodes
{
    public sealed class CourseNode : Node
    {
        private const string Suffix = "CourseNode";
        private readonly NodeRow _node;

        public CourseNode(NodeRow node)
        {
            _node = node;
            IdNode = $"{node.Tag}{Suffix}";
            Label = $"{node.Tag} Courses";
        }

        public override string IdNode { get; }
        public override string Label { get; }

        public override int Level { get; } = 2;

        public override string ToString()
        {
            var items1 = new string(';', RepositoryInfoEntity.Captions().Count - 1);
            var items2 = new string(';', CourseEntity.Captions().Count - 1);
            var items3 = new string(';', UserEntity.Captions().Count - 1);

            return $"{IdNode};{Label};{Level};{_node.Tag};{items1};{items2};{items3}";
        }
    }
}
