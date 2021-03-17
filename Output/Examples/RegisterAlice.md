
Alice registers the callsign alice it has the canonical form
alice.

~~~~
{
  "Id": "alice",
  "Presentation": "alice",
  "Holder": "MBHS-EKNA-7EJZ-VMUQ-HI5U-4FH3-RV3T",
  "Service": "provisional"}
~~~~

The registrar receives the request and forwards it to the registry which creates a 
registration record that is enrolled in the callsign log:


~~~~
{
  "Id": "NB46-4NWF-ZYZ6-GEZY-OKLS-5VJK-LEJU",
  "SignedCallsign": [{
      "dig": "S512"},
    "ewogICJDYWxsc2lnbiI6IHsKICAgICJJZCI6ICJhbGljZSIsCiAgICA
  iUHJlc2VudGF0aW9uIjogImFsaWNlIiwKICAgICJIb2xkZXIiOiAiTUJIUy1FS
  05BLTdFSlotVk1VUS1ISTVVLTRGSDMtUlYzVCIsCiAgICAiU2VydmljZSI6ICJ
  wcm92aXNpb25hbCJ9fQ",
    {
      "signatures": [{
          "alg": "S512",
          "kid": "MBHS-EKNA-7EJZ-VMUQ-HI5U-4FH3-RV3T",
          "signature": "EeTMZx7MAVskcP87n7bj3yz9ukgGs22etareDWrfjBSmtcbv3
  p6zYuamKlVrgO3LdHpC7TDNLcuAEBc2OMj2ycTj_blGkAX9sw1RuUREyM4S3HV
  0g-PUwSzDFkBItBKMpE0nVKq35d8SehWdA9CSCDMA"}],
      "PayloadDigest": "IKtQPyuBxPdM81GeFEMCsTK1WG4xyp_xsI3yUjyuURfII
  AGgYVh0JVd5M59V742SHthSC5abV30gCu3W4q6_FA"}],
  "Submitted": "2021-03-17T00:22:45Z",
  "Reason": "Initial"}
~~~~
