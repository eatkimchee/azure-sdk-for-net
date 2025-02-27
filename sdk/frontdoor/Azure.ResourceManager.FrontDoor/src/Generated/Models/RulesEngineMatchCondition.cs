// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Define a match condition. </summary>
    public partial class RulesEngineMatchCondition
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RulesEngineMatchCondition"/>. </summary>
        /// <param name="rulesEngineMatchVariable"> Match Variable. </param>
        /// <param name="rulesEngineOperator"> Describes operator to apply to the match condition. </param>
        /// <param name="rulesEngineMatchValue"> Match values to match against. The operator will apply to each value in here with OR semantics. If any of them match the variable with the given operator this match condition is considered a match. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rulesEngineMatchValue"/> is null. </exception>
        public RulesEngineMatchCondition(RulesEngineMatchVariable rulesEngineMatchVariable, RulesEngineOperator rulesEngineOperator, IEnumerable<string> rulesEngineMatchValue)
        {
            if (rulesEngineMatchValue == null)
            {
                throw new ArgumentNullException(nameof(rulesEngineMatchValue));
            }

            RulesEngineMatchVariable = rulesEngineMatchVariable;
            RulesEngineOperator = rulesEngineOperator;
            RulesEngineMatchValue = rulesEngineMatchValue.ToList();
            Transforms = new ChangeTrackingList<RulesEngineMatchTransform>();
        }

        /// <summary> Initializes a new instance of <see cref="RulesEngineMatchCondition"/>. </summary>
        /// <param name="rulesEngineMatchVariable"> Match Variable. </param>
        /// <param name="selector"> Name of selector in RequestHeader or RequestBody to be matched. </param>
        /// <param name="rulesEngineOperator"> Describes operator to apply to the match condition. </param>
        /// <param name="isNegateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="rulesEngineMatchValue"> Match values to match against. The operator will apply to each value in here with OR semantics. If any of them match the variable with the given operator this match condition is considered a match. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RulesEngineMatchCondition(RulesEngineMatchVariable rulesEngineMatchVariable, string selector, RulesEngineOperator rulesEngineOperator, bool? isNegateCondition, IList<string> rulesEngineMatchValue, IList<RulesEngineMatchTransform> transforms, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RulesEngineMatchVariable = rulesEngineMatchVariable;
            Selector = selector;
            RulesEngineOperator = rulesEngineOperator;
            IsNegateCondition = isNegateCondition;
            RulesEngineMatchValue = rulesEngineMatchValue;
            Transforms = transforms;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RulesEngineMatchCondition"/> for deserialization. </summary>
        internal RulesEngineMatchCondition()
        {
        }

        /// <summary> Match Variable. </summary>
        public RulesEngineMatchVariable RulesEngineMatchVariable { get; set; }
        /// <summary> Name of selector in RequestHeader or RequestBody to be matched. </summary>
        public string Selector { get; set; }
        /// <summary> Describes operator to apply to the match condition. </summary>
        public RulesEngineOperator RulesEngineOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? IsNegateCondition { get; set; }
        /// <summary> Match values to match against. The operator will apply to each value in here with OR semantics. If any of them match the variable with the given operator this match condition is considered a match. </summary>
        public IList<string> RulesEngineMatchValue { get; }
        /// <summary> List of transforms. </summary>
        public IList<RulesEngineMatchTransform> Transforms { get; }
    }
}
