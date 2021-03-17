
Alice decides to change her service provider to provider. She
also decides that her callsign looks better with an initial capital and so changes the 
presentation form to Alice. This change does not
require require a new callsign to be registered as this has tghe same canonical form
alice.

~~~~
{
  "Id": "alice",
  "Presentation": "Alice",
  "Holder": "MBHS-EKNA-7EJZ-VMUQ-HI5U-4FH3-RV3T",
  "Service": "provider"}
~~~~

The registrar receives the request and forwards it to the registry which creates a 
registration record that is enrolled in the callsign log:

~~~~
{
  "Id": "NASO-O7YZ-Z67U-KTOG-SHIY-T3QL-WCHW",
  "SignedCallsign": [{
      "dig": "S512"},
    "ewogICJDYWxsc2lnbiI6IHsKICAgICJJZCI6ICJhbGljZSIsCiAgICA
  iUHJlc2VudGF0aW9uIjogIkFsaWNlIiwKICAgICJIb2xkZXIiOiAiTUJIUy1FS
  05BLTdFSlotVk1VUS1ISTVVLTRGSDMtUlYzVCIsCiAgICAiU2VydmljZSI6ICJ
  wcm92aWRlciJ9fQ",
    {
      "signatures": [{
          "alg": "S512",
          "kid": "MBHS-EKNA-7EJZ-VMUQ-HI5U-4FH3-RV3T",
          "signature": "l5kZXYUpcoieHn8uIIRLnF4aP3uyi7Ekk6bpWkeg7NWLwcImh
  XPDrXJo4HRPMWFExJtPpv41gPcAcAlgTIe3RISgI5_GNcuIaBJdwGytp1dbl0H
  siciPvxDKaTC1RWUPA1wG_UXzC4Xc-gO64ZK4BzQA"}],
      "PayloadDigest": "Et8xDoEm1MDB4X3o9vAUiDWvbjlZNVR5ZsQMQeX6vX8OC
  cEzL5lkD9zDxPwc8ecug_CCxdNpMoVhOeecygZ2Wg"}],
  "Submitted": "2021-03-17T13:39:54Z",
  "Reason": "Initial"}
~~~~
