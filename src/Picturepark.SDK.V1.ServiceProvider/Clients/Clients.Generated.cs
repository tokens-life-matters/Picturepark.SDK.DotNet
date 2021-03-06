﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v10.6.6324.32485 (NJsonSchema v8.33.6323.36213) (http://NSwag.org)
// </auto-generated>
//----------------------

using Picturepark.SDK.V1.ServiceProvider.Contract;

namespace Picturepark.SDK.V1.ServiceProvider
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.32485")]
    public partial class ServiceProviderRestClient : ClientBase, IServiceProviderRestClient
    {
        private string _baseUrl = "";
        
        public ServiceProviderRestClient(Picturepark.SDK.V1.Contract.IPictureparkClientSettings configuration) : base(configuration)
        {
        }
    
        public string BaseUrl 
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
    
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
    
        /// <exception cref="ApiException">A server side error occurred.</exception>
        /// <exception cref="ApiException{PictureparkException}">A server side error occurred.</exception>
        public System.Threading.Tasks.Task SendMessageAsync(string serviceProviderId, SendMessageRequest request)
        {
            return SendMessageAsync(serviceProviderId, request, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        /// <exception cref="ApiException{PictureparkException}">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task SendMessageAsync(string serviceProviderId, SendMessageRequest request, System.Threading.CancellationToken cancellationToken)
        {
            if (serviceProviderId == null)
                throw new System.ArgumentNullException("serviceProviderId");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/API/V1/ServiceProviders/{ServiceProviderId}/Message");
            urlBuilder_.Replace("{ServiceProviderId}", System.Uri.EscapeDataString(serviceProviderId.ToString()));
    
            var client_ = await CreateHttpClientAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request, new Newtonsoft.Json.JsonConverter[] { new JsonExceptionConverter() }));
                    content_.Headers.ContentType.MediaType = "application/json";
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "500") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(PictureparkException); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<PictureparkException>(responseData_, new Newtonsoft.Json.JsonConverter[] { new JsonExceptionConverter() });
                            } 
                            catch (System.Exception exception) 
                            {
                                throw new ApiException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
                            }
                            if (result_ == null)
                                result_ = new PictureparkException();
                            result_.Data.Add("HttpStatus", status_);
                            result_.Data.Add("HttpHeaders", headers_);
                            result_.Data.Add("HttpResponse", responseData_);
                            throw new ApiException<PictureparkException>("A server side error occurred.", status_, responseData_, headers_, result_, result_);
                        }
                        else
                        if (status_ == "204") 
                        {
                            return;
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }
    
        /// <exception cref="ApiException">A server side error occurred.</exception>
        /// <exception cref="ApiException{PictureparkException}">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<CustomerServiceProviderConfigurationViewItem> GetConfigurationAsync(string serviceProviderId)
        {
            return GetConfigurationAsync(serviceProviderId, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        /// <exception cref="ApiException{PictureparkException}">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<CustomerServiceProviderConfigurationViewItem> GetConfigurationAsync(string serviceProviderId, System.Threading.CancellationToken cancellationToken)
        {
            if (serviceProviderId == null)
                throw new System.ArgumentNullException("serviceProviderId");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/API/V1/ServiceProviders/{ServiceProviderId}/Configuration");
            urlBuilder_.Replace("{ServiceProviderId}", System.Uri.EscapeDataString(serviceProviderId.ToString()));
    
            var client_ = await CreateHttpClientAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "500") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(PictureparkException); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<PictureparkException>(responseData_, new Newtonsoft.Json.JsonConverter[] { new JsonExceptionConverter() });
                            } 
                            catch (System.Exception exception) 
                            {
                                throw new ApiException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
                            }
                            if (result_ == null)
                                result_ = new PictureparkException();
                            result_.Data.Add("HttpStatus", status_);
                            result_.Data.Add("HttpHeaders", headers_);
                            result_.Data.Add("HttpResponse", responseData_);
                            throw new ApiException<PictureparkException>("A server side error occurred.", status_, responseData_, headers_, result_, result_);
                        }
                        else
                        if (status_ == "200") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(CustomerServiceProviderConfigurationViewItem); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<CustomerServiceProviderConfigurationViewItem>(responseData_, new Newtonsoft.Json.JsonConverter[] { new JsonExceptionConverter() });
                                return result_; 
                            } 
                            catch (System.Exception exception) 
                            {
                                throw new ApiException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
                        }
            
                        return default(CustomerServiceProviderConfigurationViewItem);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }
    
        /// <exception cref="ApiException">A server side error occurred.</exception>
        /// <exception cref="ApiException{PictureparkException}">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<CustomerServiceProviderConfigurationViewItem> UpdateConfigurationAsync(string serviceProviderId, ServiceProviderConfigurationUpdateRequest configuration)
        {
            return UpdateConfigurationAsync(serviceProviderId, configuration, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        /// <exception cref="ApiException{PictureparkException}">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<CustomerServiceProviderConfigurationViewItem> UpdateConfigurationAsync(string serviceProviderId, ServiceProviderConfigurationUpdateRequest configuration, System.Threading.CancellationToken cancellationToken)
        {
            if (serviceProviderId == null)
                throw new System.ArgumentNullException("serviceProviderId");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl).Append("/API/V1/ServiceProviders/{ServiceProviderId}/Configuration");
            urlBuilder_.Replace("{ServiceProviderId}", System.Uri.EscapeDataString(serviceProviderId.ToString()));
    
            var client_ = await CreateHttpClientAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(configuration, new Newtonsoft.Json.JsonConverter[] { new JsonExceptionConverter() }));
                    content_.Headers.ContentType.MediaType = "application/json";
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("PUT");
                    request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "500") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(PictureparkException); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<PictureparkException>(responseData_, new Newtonsoft.Json.JsonConverter[] { new JsonExceptionConverter() });
                            } 
                            catch (System.Exception exception) 
                            {
                                throw new ApiException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
                            }
                            if (result_ == null)
                                result_ = new PictureparkException();
                            result_.Data.Add("HttpStatus", status_);
                            result_.Data.Add("HttpHeaders", headers_);
                            result_.Data.Add("HttpResponse", responseData_);
                            throw new ApiException<PictureparkException>("A server side error occurred.", status_, responseData_, headers_, result_, result_);
                        }
                        else
                        if (status_ == "200") 
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(CustomerServiceProviderConfigurationViewItem); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<CustomerServiceProviderConfigurationViewItem>(responseData_, new Newtonsoft.Json.JsonConverter[] { new JsonExceptionConverter() });
                                return result_; 
                            } 
                            catch (System.Exception exception) 
                            {
                                throw new ApiException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
                            }
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
                        }
            
                        return default(CustomerServiceProviderConfigurationViewItem);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (client_ != null)
                    client_.Dispose();
            }
        }
    
    }
    
    

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.32485")]
    internal class JsonExceptionConverter : Newtonsoft.Json.JsonConverter
    {
        private readonly Newtonsoft.Json.Serialization.DefaultContractResolver _defaultContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
        private readonly System.Collections.Generic.IDictionary<string, System.Reflection.Assembly> _searchedNamespaces;
        private readonly bool _hideStackTrace = false;
        
        public JsonExceptionConverter()
        {
            _searchedNamespaces = new System.Collections.Generic.Dictionary<string, System.Reflection.Assembly> { { typeof(PictureparkException).Namespace, System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(PictureparkException)).Assembly } };
        }
        
        public override bool CanWrite => true;
        
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            var exception = value as System.Exception;
            if (exception != null)
            {
                var resolver = serializer.ContractResolver as Newtonsoft.Json.Serialization.DefaultContractResolver ?? _defaultContractResolver;
        
                var jObject = new Newtonsoft.Json.Linq.JObject();
                jObject.Add(resolver.GetResolvedPropertyName("discriminator"), exception.GetType().Name);
                jObject.Add(resolver.GetResolvedPropertyName("Message"), exception.Message);
                jObject.Add(resolver.GetResolvedPropertyName("StackTrace"), _hideStackTrace ? "HIDDEN" : exception.StackTrace);
                jObject.Add(resolver.GetResolvedPropertyName("Source"), exception.Source);
                jObject.Add(resolver.GetResolvedPropertyName("InnerException"),
                    exception.InnerException != null ? Newtonsoft.Json.Linq.JToken.FromObject(exception.InnerException, serializer) : null);
        
                foreach (var property in GetExceptionProperties(value.GetType()))
                {
                    var propertyValue = property.Key.GetValue(exception);
                    if (propertyValue != null)
                    {
                        jObject.AddFirst(new Newtonsoft.Json.Linq.JProperty(resolver.GetResolvedPropertyName(property.Value),
                            Newtonsoft.Json.Linq.JToken.FromObject(propertyValue, serializer)));
                    }
                }
        
                value = jObject;
            }
        
            serializer.Serialize(writer, value);
        }
        
        public override bool CanConvert(System.Type objectType)
        {
            return System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(System.Exception)).IsAssignableFrom(System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType));
        }
        
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var jObject = serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(reader);
            if (jObject == null)
                return null;
        
            var newSerializer = new Newtonsoft.Json.JsonSerializer();
            newSerializer.ContractResolver = (Newtonsoft.Json.Serialization.IContractResolver)System.Activator.CreateInstance(serializer.ContractResolver.GetType());
        
            GetField(typeof(Newtonsoft.Json.Serialization.DefaultContractResolver), "_sharedCache").SetValue(newSerializer.ContractResolver, false);
        
            dynamic resolver = newSerializer.ContractResolver;
            if (System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperty(newSerializer.ContractResolver.GetType(), "IgnoreSerializableAttribute") != null)
                resolver.IgnoreSerializableAttribute = true;
            if (System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperty(newSerializer.ContractResolver.GetType(), "IgnoreSerializableInterface") != null)
                resolver.IgnoreSerializableInterface = true;
        
            Newtonsoft.Json.Linq.JToken token;
            if (jObject.TryGetValue("discriminator", System.StringComparison.OrdinalIgnoreCase, out token))
            {
                var discriminator = Newtonsoft.Json.Linq.Extensions.Value<string>(token);
                if (objectType.Name.Equals(discriminator) == false)
                {
                    var exceptionType = System.Type.GetType("System." + discriminator, false);
                    if (exceptionType != null)
                        objectType = exceptionType;
                    else
                    {
                        foreach (var pair in _searchedNamespaces)
                        {
                            exceptionType = pair.Value.GetType(pair.Key + "." + discriminator);
                            if (exceptionType != null)
                            {
                                objectType = exceptionType;
                                break;
                            }
                        }
        
                    }
                }
            }
        
            var value = jObject.ToObject(objectType, newSerializer);
            foreach (var property in GetExceptionProperties(value.GetType()))
            {
                var jValue = jObject.GetValue(resolver.GetResolvedPropertyName(property.Value));
                var propertyValue = (object)jValue?.ToObject(property.Key.PropertyType);
                if (property.Key.SetMethod != null)
                    property.Key.SetValue(value, propertyValue);
                else
                {
                    var field = GetField(objectType, "m_" + property.Value.Substring(0, 1).ToLowerInvariant() + property.Value.Substring(1));
                    if (field != null)
                        field.SetValue(value, propertyValue);
                }
            }
        
            SetExceptionFieldValue(jObject, "Message", value, "_message", resolver, newSerializer);
            SetExceptionFieldValue(jObject, "StackTrace", value, "_stackTraceString", resolver, newSerializer);
            SetExceptionFieldValue(jObject, "Source", value, "_source", resolver, newSerializer);
            SetExceptionFieldValue(jObject, "InnerException", value, "_innerException", resolver, serializer);
        
            return value;
        }
        
        private System.Reflection.FieldInfo GetField(System.Type type, string fieldName)
        {
            var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(type).GetDeclaredField(fieldName);
            if (field == null && System.Reflection.IntrospectionExtensions.GetTypeInfo(type).BaseType != null)
                return GetField(System.Reflection.IntrospectionExtensions.GetTypeInfo(type).BaseType, fieldName);
            return field;
        }
        
        private System.Collections.Generic.IDictionary<System.Reflection.PropertyInfo, string> GetExceptionProperties(System.Type exceptionType)
        {
            var result = new System.Collections.Generic.Dictionary<System.Reflection.PropertyInfo, string>();
            foreach (var property in System.Linq.Enumerable.Where(System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(exceptionType), 
                p => p.GetMethod?.IsPublic == true))
            {
                var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(property);
                var propertyName = attribute != null ? attribute.PropertyName : property.Name;
        
                if (!System.Linq.Enumerable.Contains(new[] { "Message", "StackTrace", "Source", "InnerException", "Data", "TargetSite", "HelpLink", "HResult" }, propertyName))
                    result[property] = propertyName;
            }
            return result;
        }
        
        private void SetExceptionFieldValue(Newtonsoft.Json.Linq.JObject jObject, string propertyName, object value, string fieldName, Newtonsoft.Json.Serialization.IContractResolver resolver, Newtonsoft.Json.JsonSerializer serializer)
        {
            var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(System.Exception)).GetDeclaredField(fieldName);
            var jsonPropertyName = resolver is Newtonsoft.Json.Serialization.DefaultContractResolver ? ((Newtonsoft.Json.Serialization.DefaultContractResolver)resolver).GetResolvedPropertyName(propertyName) : propertyName;
            if (jObject[jsonPropertyName] != null)
            {
                var fieldValue = jObject[jsonPropertyName].ToObject(field.FieldType, serializer);
                field.SetValue(value, fieldValue);
            }
        }
    }

}