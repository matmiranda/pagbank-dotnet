namespace PagBank.Extension
{
    public static class EnumExtension
    {
        public static string GetDescription(this BaseUrl value)
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString())[0];
            var attributes = memberInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}
