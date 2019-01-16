using Moq;
using System.Collections.Specialized;
using System.Web;

namespace ContosoUniversity.Tests.Tools
{
    public class MockHttpContextWrapper
    {

        public MockHttpContextWrapper()
        {
            Context = new Mock<HttpContextBase>();
            Request = new Mock<HttpRequestBase>();
            Response = new Mock<HttpResponseBase>();
            SessionState = new Mock<HttpSessionStateBase>();
            ServerUtility = new Mock<HttpServerUtilityBase>();
            Context.Setup(c => c.Request).Returns(Request.Object);
            Context.Setup(c => c.Response).Returns(Response.Object);
            Context.Setup(c => c.Session).Returns(SessionState.Object);
            Context.Setup(c => c.Server).Returns(ServerUtility.Object);
        }

        public Mock<HttpContextBase> Context { get; private set; }
        public Mock<HttpRequestBase> Request { get; }
        public Mock<HttpResponseBase> Response { get; }
        public Mock<HttpSessionStateBase> SessionState { get; }
        public Mock<HttpServerUtilityBase> ServerUtility { get; }

        private NameValueCollection formData;
        public NameValueCollection FormData
        {
            get
            {
                if (formData == null)
                {
                    formData = new NameValueCollection();
                    this.Request.Setup(r => r.Form).Returns(formData);
                }
                return formData;
            }
        }
    }
}
