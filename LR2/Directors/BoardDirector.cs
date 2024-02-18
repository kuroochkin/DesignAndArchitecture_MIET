using LR2.Builders.BoardBuilder.Abstraction;

namespace LR2.Directors
{
    public class BoardDirector
    {
        private readonly IBoardBuilder _builder;
        
        public BoardDirector(IBoardBuilder builder)
        {
            _builder = builder;
        }

        public void Go()
        {
            _builder.Go();
        }
    }
}