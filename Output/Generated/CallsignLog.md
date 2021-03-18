

##Callsign log entries

###Callsign registration and transfer

The following classes are used as common elements in
Mesh profile specifications.

###Structure: Callsign

A callsign entry

<dl>
<dt>Id: String (Optional)
<dd>The callsign identifier in canonical form used for query.
<dt>Presentation: String (Optional)
<dd>The callsign identifier in the prefered presentation form.
<dt>Holder: String (Optional)
<dd>The UDF of the holder's root of trust
<dt>Alias: String (Optional)
<dd>This callsign is an alias for another registered callsign.
<dt>Service: String (Optional)
<dd>The callsign or DNS address of the service provider
<dt>Dns: String [0..Many]
<dd>Address(es) of a DNS service that resolves the authoritative domain 
'id.mesh'.
<dt>Account: ProfileAccount (Optional)
<dd>The Mesh Account profile to which the callsign belongs.
</dl>
###Structure: Registration

A callsign or Notarization registration

<dl>
<dt>Id: String (Optional)
<dd>Unique registration identifier
<dt>Entry: Enveloped<CallsignEntry> (Optional)
<dd>Envelope containing the item that has been registered.
<dt>Submitted: DateTime (Optional)
<dd>The UTC time instant that the claim was submitted.
<dt>Registrar: String (Optional)
<dd>Callsign of the registrar that made the registration request
<dt>PriorId: String (Optional)
<dd>If present, specifies a previous registration with the same identifier.
<dt>Reason: String (Optional)
<dd>Reason for creating a registration:
Initial/ Update/ Voluntary/ Administrative/ Revoke
</dl>
###Character page definition

###Structure: Page

<dl>
<dt>Id: String (Optional)
<dd>Character page identifier
<dt>Allow: String [0..Many]
<dd>Additional allowed pages.
</dl>
###Structure: CharacterSpan

<dl>
<dt>First: Integer (Optional)
<dd>The first character in the range (inclusive)
<dt>Last: Integer (Optional)
<dd>The last character in the range (inclusive), if ommitted or
equal to zero, this is the same as Last.
</dl>
###Structure: Canonical

<dl>
<dt>Inherits:  CharacterSpan
</dl>

Canonical character span.

[No fields]

###Structure: MapChar

<dl>
<dt>Inherits:  CharacterSpan
</dl>

Specifies a variant mapping the range of characters First..First+n to
a range of characters Target..Target+n. Where n = Last - First+1

<dl>
<dt>Target: Integer (Optional)
<dd>The character that First is mapped to.
</dl>
###Structure: MapString

<dl>
<dt>Inherits:  CharacterSpan
</dl>

Specifies a mapping of non canonical characters in the range specified by 
First..Last to the string Target.

<dl>
<dt>Target: String (Optional)
<dd>Specifies a character string that the Source character(s) are mapped to.
If count is greater than 1, all the characters map to the same string.
</dl>
###Notarization

###Structure: Notarization

<dl>
<dt>Entries: Enveloped<Witness> [0..Many]
<dd>Enveloped witness value of a specific append only log.
<dt>Proof: Proof (Optional)
<dd>Proof path validating the previous notary token that was entered in the
log.
</dl>
###Trust Assertions

###Structure: ProfileDns



<dl>
<dt>SecurityPolicies: SecurityPolicy [0..Many]
<dd>Specify TLS policies for use in the zone.
</dl>
###Structure: SecurityPolicy

<dl>
<dt>CName: String [0..Many]
<dd>The DNS zone(s) to which this policy applies.
<dt>Protocol: String [0..Many]
<dd>IANA protocol name, e.g. SMTP, SUBMIT, HTTP, HTTPS, etc.		
<dt>Enhancements: String [0..Many]
<dd>Enhancements that are supported for the specified protocol. 
Allowed values include none/ tls1.2/ tls1.3/ http3/ dnssec
<dt>Require: Boolean (Optional)
<dd>If true, clients MUST use one of the supported enhancements.		
<dt>Roots: KeyData [0..Many]
<dd>Keys specifying roots of trust for the specified protocol(s).
</dl>
###Structure: Accreditation

Registration of a trusted third party accreditation

<dl>
<dt>Callsign: String (Optional)
<dd>The callsigns to which the accreditation applies
<dt>SubjectNames: String [0..Many]
<dd>The validated names of the subject
<dt>SubjectLogos: String [0..Many]
<dd>Mesh strong URIs from which a validated logo belonging to the 
subject MAY be retreived and validated.
<dt>Issued: DateTime (Optional)
<dd>The time the assertion was issued.
<dt>Expires: DateTime (Optional)
<dd>The time the assertion is due to expire
<dt>Policy: String (Optional)
<dd>The issuing policy under which the validation was performed.
<dt>Practice: String (Optional)
<dd>The issuing practices under which the validation was performed.
</dl>
###Structure: Challenge

Registers a challenge to one or more callsigns that have been registered.

<dl>
<dt>Subjects: String [0..Many]
<dd>The callsigns subject to challenge
<dt>Basis: String [0..Many]
<dd>The basis for the challenge
</dl>
