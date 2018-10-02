﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace TelerikSilverlightApp1.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="ServiceReference2.MyService")]
    public interface MyService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:MyService/GetFilieresStats", ReplyAction="urn:MyService/GetFilieresStatsResponse")]
        System.IAsyncResult BeginGetFilieresStats(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.Dictionary<string, int> EndGetFilieresStats(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:MyService/GetAllStudents", ReplyAction="urn:MyService/GetAllStudentsResponse")]
        System.IAsyncResult BeginGetAllStudents(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> EndGetAllStudents(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyServiceChannel : TelerikSilverlightApp1.ServiceReference2.MyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetFilieresStatsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetFilieresStatsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.Dictionary<string, int> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.Dictionary<string, int>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllStudentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllStudentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<TelerikSilverlightApp1.ServiceReference2.MyService>, TelerikSilverlightApp1.ServiceReference2.MyService {
        
        private BeginOperationDelegate onBeginGetFilieresStatsDelegate;
        
        private EndOperationDelegate onEndGetFilieresStatsDelegate;
        
        private System.Threading.SendOrPostCallback onGetFilieresStatsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllStudentsDelegate;
        
        private EndOperationDelegate onEndGetAllStudentsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllStudentsCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetFilieresStatsCompletedEventArgs> GetFilieresStatsCompleted;
        
        public event System.EventHandler<GetAllStudentsCompletedEventArgs> GetAllStudentsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult TelerikSilverlightApp1.ServiceReference2.MyService.BeginGetFilieresStats(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetFilieresStats(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.Dictionary<string, int> TelerikSilverlightApp1.ServiceReference2.MyService.EndGetFilieresStats(System.IAsyncResult result) {
            return base.Channel.EndGetFilieresStats(result);
        }
        
        private System.IAsyncResult OnBeginGetFilieresStats(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((TelerikSilverlightApp1.ServiceReference2.MyService)(this)).BeginGetFilieresStats(callback, asyncState);
        }
        
        private object[] OnEndGetFilieresStats(System.IAsyncResult result) {
            System.Collections.Generic.Dictionary<string, int> retVal = ((TelerikSilverlightApp1.ServiceReference2.MyService)(this)).EndGetFilieresStats(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetFilieresStatsCompleted(object state) {
            if ((this.GetFilieresStatsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetFilieresStatsCompleted(this, new GetFilieresStatsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetFilieresStatsAsync() {
            this.GetFilieresStatsAsync(null);
        }
        
        public void GetFilieresStatsAsync(object userState) {
            if ((this.onBeginGetFilieresStatsDelegate == null)) {
                this.onBeginGetFilieresStatsDelegate = new BeginOperationDelegate(this.OnBeginGetFilieresStats);
            }
            if ((this.onEndGetFilieresStatsDelegate == null)) {
                this.onEndGetFilieresStatsDelegate = new EndOperationDelegate(this.OnEndGetFilieresStats);
            }
            if ((this.onGetFilieresStatsCompletedDelegate == null)) {
                this.onGetFilieresStatsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetFilieresStatsCompleted);
            }
            base.InvokeAsync(this.onBeginGetFilieresStatsDelegate, null, this.onEndGetFilieresStatsDelegate, this.onGetFilieresStatsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult TelerikSilverlightApp1.ServiceReference2.MyService.BeginGetAllStudents(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllStudents(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> TelerikSilverlightApp1.ServiceReference2.MyService.EndGetAllStudents(System.IAsyncResult result) {
            return base.Channel.EndGetAllStudents(result);
        }
        
        private System.IAsyncResult OnBeginGetAllStudents(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((TelerikSilverlightApp1.ServiceReference2.MyService)(this)).BeginGetAllStudents(callback, asyncState);
        }
        
        private object[] OnEndGetAllStudents(System.IAsyncResult result) {
            System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> retVal = ((TelerikSilverlightApp1.ServiceReference2.MyService)(this)).EndGetAllStudents(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllStudentsCompleted(object state) {
            if ((this.GetAllStudentsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllStudentsCompleted(this, new GetAllStudentsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllStudentsAsync() {
            this.GetAllStudentsAsync(null);
        }
        
        public void GetAllStudentsAsync(object userState) {
            if ((this.onBeginGetAllStudentsDelegate == null)) {
                this.onBeginGetAllStudentsDelegate = new BeginOperationDelegate(this.OnBeginGetAllStudents);
            }
            if ((this.onEndGetAllStudentsDelegate == null)) {
                this.onEndGetAllStudentsDelegate = new EndOperationDelegate(this.OnEndGetAllStudents);
            }
            if ((this.onGetAllStudentsCompletedDelegate == null)) {
                this.onGetAllStudentsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllStudentsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllStudentsDelegate, null, this.onEndGetAllStudentsDelegate, this.onGetAllStudentsCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override TelerikSilverlightApp1.ServiceReference2.MyService CreateChannel() {
            return new MyServiceClientChannel(this);
        }
        
        private class MyServiceClientChannel : ChannelBase<TelerikSilverlightApp1.ServiceReference2.MyService>, TelerikSilverlightApp1.ServiceReference2.MyService {
            
            public MyServiceClientChannel(System.ServiceModel.ClientBase<TelerikSilverlightApp1.ServiceReference2.MyService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetFilieresStats(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetFilieresStats", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.Dictionary<string, int> EndGetFilieresStats(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.Dictionary<string, int> _result = ((System.Collections.Generic.Dictionary<string, int>)(base.EndInvoke("GetFilieresStats", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetAllStudents(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetAllStudents", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> EndGetAllStudents(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>> _result = ((System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ObservableCollection<string>>)(base.EndInvoke("GetAllStudents", _args, result)));
                return _result;
            }
        }
    }
}
