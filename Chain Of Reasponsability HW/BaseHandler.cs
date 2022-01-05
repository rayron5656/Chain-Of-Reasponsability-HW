namespace Chain_Of_Reasponsability_HW
{
    public abstract class BaseHandler
    {
        protected BaseHandler Next;

        public void SetNext(BaseHandler myNext)
        {
            this.Next = myNext;

        }

        public abstract void HandleRequest(car C);


    }
}
