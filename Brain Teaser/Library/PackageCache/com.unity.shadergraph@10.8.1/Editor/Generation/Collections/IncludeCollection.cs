using System.Collections;
using System.Collections.Generic;

namespace UnityEditor.ShaderGraph
{
    [GenerationAPI]
    internal class IncludeCollection : IEnumerable<IncludeCollection.Item>
    {
        public class Item : IConditional, IShaderString
        {
            public IncludeDescriptor descriptor { get; }
            public FieldCondition[] fieldConditions { get; }
            public string value => $"#include \"{descriptor.value}\"";

            public Item(IncludeDescriptor descriptor, FieldCondition[] fieldConditions)
            {
                this.descriptor = descriptor;
                this.fieldConditions = fieldConditions;
            }
        }

        readonly List<Item> m_Items;

        public IncludeCollection()
        {
            m_Items = new List<Item>();
        }

        public IncludeCollection Add(IncludeCollection includes)
        {
            foreach(IncludeCollection.Item item in includes)
            {
                m_Items.Add(item);
            }
            return this;
        }

        public IncludeCollection Add(string include, IncludeLocation location)
        {
            m_Items.Add(new Item(new IncludeDescriptor() { value = include, location = location }, null));
            return this;
        }

        public IncludeCollection Add(string include, IncludeLocation location, FieldCondition fieldCondition)
        {
            m_Items.Add(new Item(new IncludeDescriptor() { value = include, location = location }, new FieldCondition[]{ fieldCondition }));
            return this;
        }

        public IncludeCollection Add(string include, IncludeLocation location, FieldCondition[] fieldConditions)
        {
            m_Items.Add(new Item(new IncludeDescriptor() { value = include, location = location }, fieldConditions));
            return this;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return m_Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
