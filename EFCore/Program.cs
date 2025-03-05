// See https://aka.ms/new-console-template for more information
using EFCore;
using EFCore.Model;

var _context = new ApplictionDBContext();

_context.SaveChanges();
