# Code Generation Instructions

Use this checklist whenever generating or updating DTOs from ONVIF schemas.

## Checklist

- [ ] Check XML annotations (`XmlRoot`, `XmlType`, `XmlElement`, `XmlAttribute`, namespaces) match the XSD exactly.
- [ ] Confirm element vs. attribute mapping for every field (do not assume).
- [ ] Do not diverge from XSD types: avoid placeholder `XmlElement`/`XmlElement[]` DTO properties when schema defines concrete types.
- [ ] HARD RULE: `XmlElement`/`XmlElement[]` as DTO property types are forbidden for schema-defined elements. They are allowed only for explicit wildcard/extensibility (`xs:any` via `XmlAnyElement`) or `xop:Include` payloads.
- [ ] HARD RULE: Concrete XSD complex/simple types must be represented by concrete DTO types; do not use placeholder "Any" classes for schema-defined structures.
- [ ] Verify XML namespaces on all types and members.
- [ ] Keep changes scoped to DTO/schema mapping only unless explicitly requested.
- [ ] Prefer optional fields (`minOccurs=0`) to nullable/optional DTO members where appropriate.
- [ ] Handle repeated elements (`maxOccurs>1`) as arrays/collections.
- [ ] Preserve extension points (`xs:any`, `xs:anyAttribute`) when needed for compatibility.
- [ ] Validate against a real sample XML response in addition to schema review.
- [ ] Ensure request and response root element names match service contract.
- [ ] Build the solution after DTO updates.

## New Function Addition Flow (Service Clients)

- [ ] Create DTOs first (request/response and nested types) from WSDL/XSD.
- [ ] DTOs must be schema-first and strictly typed according to XSD imported types.
- [ ] Add the function to the relevant service client (`DeviceClient`, `ImagingClient`, etc.).
- [ ] Add a service-specific XML capture test that calls the real device and saves the raw XML response into `OnvifTests/DeserializationTests/Responses`.
- [ ] Use renamed test classes/files consistently (for example `DeviceGetXmlResponseTests` for device service, `Imaging...` tests for imaging service).
- [ ] Add a deserialization test that validates DTO mapping from the saved XML.
- [ ] Add a call to the new client function in the matching client sanity test (`DeviceClientTests`, `ImagingClientTests`, etc.).

## Fault Response Handling

- [ ] For operations that are optional/not implemented on some devices, add a deserialization test and mark it `[Ignore("...")]` with clear reason.
- [ ] Keep fault-aware assertions in tests where relevant (`Fault.Code`, `Fault.Reason.Text`).
- [ ] Document in the test name/message when a method is optional and fault is acceptable.

## Migration Reliability Checklist (Lessons Learned)

- [ ] For `XmlAttribute` fields, avoid nullable value types (`bool?`, `int?`) with `XmlSerializer`; use `string` or non-nullable + `Specified` pattern.
- [ ] Watch for duplicate XML element names across the DTO graph (for example `Extension`) that can cause serializer reflection conflicts; use `XmlAnyElement` where appropriate.
- [ ] When schema uses `xs:any` / unknown extensions, prefer `XmlAnyElement` / `XmlAnyAttribute` for compatibility.
- [ ] Save real device response fixtures as single well-formed XML documents (no duplicated XML declaration or duplicated root tags).
- [ ] Add exactly 2 tests per new operation:
  - [ ] XML capture test (service-specific capture test class, e.g. `DeviceGetXmlResponseTests`)
  - [ ] Deserialization test (`DeserializationTests`)
- [ ] Update the matching service `Sanity` test to call the new client function.
- [ ] Completion gate: no generic placeholder DTOs remain (`XmlElement`, `XmlElement[]`, `object`, `dynamic`, or "Any" placeholder classes) except where the XSD explicitly defines wildcard/extensible content (`xs:any`, `xs:anyAttribute`, `xop:Include`).
- [ ] Run focused test filters first, then run full build.
- [ ] If deserialization fails, inspect `.trx` output for the exact `XmlSerializer` reflection error before changing DTOs.
- [ ] If an operation returns fault on the target device, keep capture test fault-aware and skip success deserialization test with explicit ignore reason.
